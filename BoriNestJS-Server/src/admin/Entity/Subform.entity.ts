/* eslint-disable prettier/prettier */
import { BaseEntity, Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity()
export class subform_info extends BaseEntity {
  // id
  @PrimaryGeneratedColumn()
  id: number;

  // 제목
  @Column()
  title: string;
  
  // 설명
  @Column()
  description: string;

  // 이미지 이름
  @Column()
  img: string;

  // 이미지 URL
  @Column()
  imgurl: string;
}
