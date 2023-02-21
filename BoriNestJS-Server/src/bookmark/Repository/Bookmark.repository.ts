/* eslint-disable prettier/prettier */
/* eslint-disable prefer-const */
import { CustomRepository } from 'src/Custom/typeorm-ex.decorator';
import { DeleteResult, Repository } from 'typeorm';
import { bookmark_info } from '../Entity/BookMark.entity';
import { BookmarkInfoDto } from '../Dto/BookmarkInfo.dto';
import { NotFoundException } from '@nestjs/common';

@CustomRepository(bookmark_info)
export class BookmarkRepository extends Repository<bookmark_info> {
  /*
    createBookmarkInfo 사용하여 BookmarkInfoDto 테이블에 데이터 등록
  */
  async createBookmarkInfo(
    createBookmarkInfoDto: BookmarkInfoDto,
  ): Promise<bookmark_info> {
    let {
      id,
      tag,
      picket
    }: BookmarkInfoDto = createBookmarkInfoDto;

    const bookmark = this.create({
      id,
      tag,
      picket
    });

    await this.save(bookmark);
    return bookmark;
  }

  async deleteBookmarkInfo(id: number): Promise<boolean> {
    const result: DeleteResult = await this.delete(id);
    if (result.affected === 0) {
      return false;
    }

    return true;
  }

  async getBookmark(id:string): Promise<bookmark_info[]> {
    const bookmark:bookmark_info[] = await this.find({ where: {id}})
    if (!bookmark) {
      throw new NotFoundException(`Not Found Id: {${id}`);
    }

    return bookmark;
  }
}
