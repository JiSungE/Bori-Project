/* eslint-disable prettier/prettier */
import { Injectable } from '@nestjs/common';
import { BookmarkInfoDto } from './Dto/BookmarkInfo.dto';
import { bookmark_info } from './Entity/BookMark.entity';
import { BookmarkRepository } from './Repository/Bookmark.repository';


@Injectable()
export class BookmarkService {
  constructor(
    private BookmarkRepository: BookmarkRepository,
  ) {}

  /*
    BookmarkInfoDto를 JSON으로 받아 데이터베이스에 등록하는 기능
  */
  createBookmarkInfo(
    createBookmarkInfoDto: BookmarkInfoDto,
  ): Promise<bookmark_info> {
    return this.BookmarkRepository.createBookmarkInfo(createBookmarkInfoDto);
  }

  // JSON으로 받은 ID값을 통해 북마크를 삭제하는 기능
  deleteBookmarkInfo(id: number): Promise<boolean> {
    return this.BookmarkRepository.deleteBookmarkInfo(id);
  }

  // ID값을 통해 북마크를 삭제하는 기능
  getBookmark(id:string): Promise<bookmark_info[]> {
    return this.BookmarkRepository.getBookmark(id);
  }

}
