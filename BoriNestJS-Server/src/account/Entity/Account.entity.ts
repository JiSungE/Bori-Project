/* eslint-disable prettier/prettier */
import { BaseEntity, Column, Entity, PrimaryColumn, PrimaryGeneratedColumn } from 'typeorm';

@Entity()
export class account_info extends BaseEntity {
  @PrimaryColumn()
  @PrimaryGeneratedColumn()
  pkid: number;

  @Column()
  id: string;

  @Column()
  pw: string;
}
