/* eslint-disable prettier/prettier */
import { CustomRepository } from 'src/Custom/typeorm-ex.decorator';
import { DeleteResult, Repository } from 'typeorm';
import { CreateMainFormInfoDto } from '../Dto/CreateMainFormInfo.dto';
import { subform_info } from '../Entity/Subform.entity';
import { CreateSubFormInfoDto } from '../Dto/CreateSubFormnfo.dto';
import { NotFoundException } from '@nestjs/common';

@CustomRepository(subform_info)
export class SubFormInfoRepository extends Repository<subform_info> {
  /*
    MarkerInfo테이블에 모든 마커 정보를 가져오는 함수
  */
  async getAllMainForm(): Promise<subform_info[]> {
    return await this.find();
  }

  async createSubFormInfo(
    createSubFormInfoDto: CreateSubFormInfoDto,
  ): Promise<subform_info> {
    const { title, description, img, imgurl }: CreateSubFormInfoDto =
      createSubFormInfoDto;
    const subform = this.create({
      title,
      description,
      img,
      imgurl,
    });
    await this.save(subform);
    return subform;
  }

  async getSubFormById(id: number): Promise<subform_info> {
    const found = await this.findOne({ where: { id } });

    if (!found) {
      throw new NotFoundException(`Can't find Board with id ${id}`);
    }

    return found;
  }

  async deleteMainFormInfo(id: number): Promise<boolean> {
    const result: DeleteResult = await this.delete(id);
    if (result.affected === 0) {
      return false;
    }

    return true;
  }

  async updateSubFormInfo(
    updateSubFormInfo: subform_info,
  ): Promise<subform_info> {
    const subform: subform_info = await this.getSubFormById(
      updateSubFormInfo.id,
    );
    subform.title = updateSubFormInfo.title;
    subform.description = updateSubFormInfo.description;
    subform.img = updateSubFormInfo.img;
    subform.imgurl = updateSubFormInfo.imgurl;

    await this.save(subform);
    return subform;
  }
}
