/* eslint-disable prettier/prettier */
import { TypeOrmModuleOptions } from '@nestjs/typeorm';
import { account_info } from 'src/account/Entity/Account.entity';
import { mainform_info } from 'src/admin/Entity/Mainform.entity';
import { subform_info } from 'src/admin/Entity/Subform.entity';
import { bookmark_info } from 'src/bookmark/Entity/BookMark.entity';
import { marker_info } from 'src/borimap/Entity/MarkerInfo.entity';

export const typeORMConfig: TypeOrmModuleOptions = {
  type: 'postgres',
  host: 'postgres.cyngkh3at8gu.ap-northeast-2.rds.amazonaws.com',
  port: 5432,
  username: 'postgres',
  password: 'QKsksktnpdlzm.5689!',
  database: 'postgres',
  entities: [__dirname + '/../**/*.entity.{js,ts}',
  marker_info,
  mainform_info,
  subform_info,
  account_info,
  bookmark_info,
  ],
  synchronize: false,
};