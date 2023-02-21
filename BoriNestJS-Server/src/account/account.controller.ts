/* eslint-disable prettier/prettier */
/* eslint-disable @typescript-eslint/no-unused-vars */
import { Body, Controller, Get, Post, UsePipes, ValidationPipe } from '@nestjs/common';
import { AccountService } from './account.service';
import { CreateAccountInfoDto } from './Dto/CreateAccountInfo.dto';
import { LoginAccountInfo } from './Dto/LoginAccountInfo.dto';
import { account_info } from './Entity/Account.entity';

@Controller('account')
export class AccountController {
    constructor(private accountService: AccountService) {}

    @Get()
    getAllMarkers(): Promise<account_info[]> {
      return this.accountService.getAllMarkers();
    }

    @Post("/login")
    loginAccount(@Body() LoginAccountInfo:LoginAccountInfo):Promise<boolean>{
      return this.accountService.loginAccount(LoginAccountInfo);
    }
  
    @Post("/createAccount")
    createAccountInfo(@Body() CreateAccountInfoDto: CreateAccountInfoDto,): Promise<account_info> {
      return this.accountService.createAccountInfo(CreateAccountInfoDto);
    }

    //아이디 중복검사 추가 (아이디가 중복되면 false값을 반환 아니면 true)
    @Post("/duplicateInspection")
    duplicateInspection(@Body('id')id : string) : Promise<boolean> {
      return this.accountService.duplicateInspection(id);
    }
}
