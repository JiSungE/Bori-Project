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
    createMarkerInfoDto를 마커를 등록하는
    저장소 함수에 보내주는 함수
  */
  createBookmarkInfo(
    createBookmarkInfoDto: BookmarkInfoDto,
  ): Promise<bookmark_info> {
    return this.BookmarkRepository.createBookmarkInfo(createBookmarkInfoDto);
  }

  deleteBookmarkInfo(id: number): Promise<boolean> {
    return this.BookmarkRepository.deleteBookmarkInfo(id);
  }

  getBookmark(id:string): Promise<bookmark_info[]> {
    return this.BookmarkRepository.getBookmark(id);
  }

}
