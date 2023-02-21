/* eslint-disable prettier/prettier */
import { Module } from '@nestjs/common';
import { TypeOrmExModule } from 'src/Custom/typeorm-ex.module';
import { BookmarkController } from './bookmark.controller';
import { BookmarkService } from './bookmark.service';
import { BookmarkRepository } from './Repository/Bookmark.repository';


@Module({
  imports: [TypeOrmExModule.forCustomRepository([BookmarkRepository])],
  controllers: [BookmarkController],
  providers: [BookmarkService],
})
export class BookmarkModule {}
