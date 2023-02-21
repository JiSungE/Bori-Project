import { Module } from '@nestjs/common';
import { TypeOrmExModule } from 'src/Custom/typeorm-ex.module';
import { AccountController } from './account.controller';
import { AccountService } from './account.service';
import { AccountInfoRepository } from './Repository/AccountInfo.repository';

@Module({
  imports:[TypeOrmExModule.forCustomRepository([AccountInfoRepository])],
  controllers: [AccountController],
  providers: [AccountService],
})
export class AccountModule {}
