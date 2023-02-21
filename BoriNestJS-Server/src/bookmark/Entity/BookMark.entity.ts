/* eslint-disable prettier/prettier */
import { BaseEntity, Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity()
export class bookmark_info extends BaseEntity {
  @PrimaryGeneratedColumn()
  pkid: number;

  @Column()
  id: string;

  @Column()
  tag: string;

  @Column()
  picket: string;
}
