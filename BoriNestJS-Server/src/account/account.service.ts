/* eslint-disable prettier/prettier */
import { Injectable } from '@nestjs/common';
import { CreateAccountInfoDto } from './Dto/CreateAccountInfo.dto';
import { LoginAccountInfo } from './Dto/LoginAccountInfo.dto';
import { account_info } from './Entity/Account.entity';
import { AccountInfoRepository } from './Repository/AccountInfo.repository';

@Injectable()
export class AccountService {
  constructor(private accountInfoRepository: AccountInfoRepository,){}
    loginAccount(LoginAccountInfo: LoginAccountInfo): Promise<boolean> {
      return this.accountInfoRepository.loginAccount(LoginAccountInfo);
    }

    getAllMarkers():Promise<account_info[]>{
        return this.accountInfoRepository.getAllAccount();
    }

    createAccountInfo(createAccountinfoDto: CreateAccountInfoDto,): Promise<account_info> {
        return this.accountInfoRepository.createAccountInfo(createAccountinfoDto);
    }

    duplicateInspection(id: string):Promise<boolean>{
      return this.accountInfoRepository.duplicateInspection(id)
    }
}