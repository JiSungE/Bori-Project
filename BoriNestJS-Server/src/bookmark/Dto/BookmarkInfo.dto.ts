/* eslint-disable prettier/prettier */
import { IsNotEmpty } from 'class-validator';
// 북마크를 생성할 때 받을 데이터 타입
export class BookmarkInfoDto {
  @IsNotEmpty()
  id: string;

  @IsNotEmpty()
  tag: string;

  @IsNotEmpty()
  picket: string;
}
