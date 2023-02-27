/* eslint-disable prettier/prettier */
import { BaseEntity, Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity()
export class mainform_info extends BaseEntity {
  // id
  @PrimaryGeneratedColumn()
  id: number;

  // 이미지 이름
  @Column()
  img: string;

  // 이미지 url
  @Column()
  imgurl: string;
}
