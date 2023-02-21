/* eslint-disable prettier/prettier */
import { CustomRepository } from 'src/Custom/typeorm-ex.decorator';
import { Repository } from 'typeorm';

import { account_info } from '../Entity/Account.entity';
import { CreateAccountInfoDto } from '../Dto/CreateAccountInfo.dto';
import { LoginAccountInfo } from '../Dto/LoginAccountInfo.dto';

@CustomRepository(account_info)
export class AccountInfoRepository extends Repository<account_info> {

//모든계정보여주기
  async getAllAccount(): Promise<account_info[]> {
    return await this.find();
  }

//계정생성
  async createAccountInfo(createAccountInfoDto: CreateAccountInfoDto,): Promise<account_info> {
    const { id,pw } = createAccountInfoDto;
    const account = this.create({
      id,
      pw,
    })
    await this.save(account);
    return account;
  }

  async loginAccount(LoginAccountInfo: LoginAccountInfo): Promise<boolean> {
    const {id,pw}=LoginAccountInfo;
    const found = await this.findOne({where:{id: LoginAccountInfo.id}});
    const getCheckID = await this.getAccountInfoByID(id);

    if (getCheckID){
      if(pw === found.pw){
        return true;
      }
      else {
        return false;
      }
    }
    else{
      return false;
    }
  }

  async getAccountInfoByID(id:string):Promise<boolean>{
    console.log(id);
    const found = await this.findOne({where:{id: id}});
    console.log(found);
    if(!found){
      return false;
    }
    return true;
  }

  async getAccountInfoByPW(pw:string):Promise<boolean>{
    const found = await this.findOne({where:{pw}});
    if(!found){
      return false;
    }
    return true;
  }

  //중복검사 
  async duplicateInspection(id: string):Promise<boolean>{
    const isEnableCheckID = await this.getAccountInfoByID(id);
    if(isEnableCheckID === false){
      return true;
    }
    else {
      return false;
    }
  }
}
