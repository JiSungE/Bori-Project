/* eslint-disable prettier/prettier */
import { Module } from '@nestjs/common';
import { BorimapModule } from './borimap/borimap.module';
import { TypeOrmModule } from '@nestjs/typeorm';
import { typeORMConfig } from './configs/typeorm.config';
import { AdminModule } from './admin/admin.module';
import { AccountModule } from './account/account.module';
import { BookmarkModule } from './bookmark/bookmark.module';

@Module({
  imports: [BorimapModule, TypeOrmModule.forRoot(typeORMConfig), AdminModule, AccountModule, BookmarkModule],
})
export class AppModule {}
