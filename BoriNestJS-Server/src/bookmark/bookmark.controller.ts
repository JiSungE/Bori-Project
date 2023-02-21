/* eslint-disable prettier/prettier */
import {
  Body,
  Controller,
  Get,
  ParseIntPipe,
  Post,
  UsePipes,
  ValidationPipe,
} from '@nestjs/common';
import { BookmarkService } from './bookmark.service';
import { BookmarkInfoDto } from './Dto/BookmarkInfo.dto';
import { bookmark_info } from './Entity/BookMark.entity';


@Controller('bookmark')
export class BookmarkController {
  // BookmarkService 의존성 주입
  constructor(private bookmarkService: BookmarkService) {}

  //#region Marker Management
  @Post()
  getBookmark(@Body('id') id:string): Promise<bookmark_info[]> {
    return this.bookmarkService.getBookmark(id);
  }

   /*
      createBookmarkInfoDto 받아서
      새롭게 데이터를 등록하는 BookmarkService함수에에 전달하는 EndPoint
    */

  @Post('/createbookmark')
  @UsePipes(ValidationPipe)
  createBookMarkInfo(
    @Body() createBookmarkInfoDto: BookmarkInfoDto,
  ): Promise<bookmark_info> {
    return this.bookmarkService.createBookmarkInfo(createBookmarkInfoDto);
  }

  @Post('/deletebookmark')
  deleteMarker(@Body('pkid', ParseIntPipe) id: number): string {
    return this.bookmarkService.deleteBookmarkInfo(id)
      ? 'Delete Complete'
      : `Not Found This Id ${id}`;
  }
}
