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
    // 받아온 Dto 데이터로 데이터베이스에 등록할 account 데이터를 생성
    const account = this.create({
      id,
      pw,
    })
    // 생성한 account 데이터를 account_info 테이블에 저장 (저장이 끝날 때까지 대기)
    await this.save(account);
    return account;
  }

  async loginAccount(LoginAccountInfo: LoginAccountInfo): Promise<boolean> {
    const {id,pw}=LoginAccountInfo;
    
    // 로그인 요청이 들어온 id가 존재하는 id인지 확인 및 정보 추출
    const found = await this.findOne({where:{id}});
    const getCheckID = await this.checkAccountInfoByID(id);

    // 비밀번호 확인 후 리턴
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

  // ID로 회원정보가 존재하는지 확인
  async checkAccountInfoByID(id:string):Promise<boolean>{
    // id가 account_info 테이블에 존재하는지 확인
    const found = await this.findOne({where:{id: id}});
    
    if(!found){
      return false;
    }
    return true;
  }

  //ID 중복검사 
  async duplicateInspection(id: string):Promise<boolean>{
    // id가 이미 데이터베이스에 존재하는지 유무확인
    const isEnableCheckID = await this.checkAccountInfoByID(id);
    if(isEnableCheckID === false){
      return true;
    }
    else {
      return false;
    }
  }
}
