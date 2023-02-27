/* eslint-disable prettier/prettier */
import { CustomRepository } from 'src/Custom/typeorm-ex.decorator';
import { DeleteResult, Repository } from 'typeorm';
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

  // createSubFormInfoDto를 JSON으로 받아 데이터베이스에 저장
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

  // id로 subform 데이터를 검색
  async getSubFormById(id: number): Promise<subform_info> {
    const found = await this.findOne({ where: { id } });

    // 찾지 못했다면 NotFoundException 에러 발생
    if (!found) {
      throw new NotFoundException(`Can't find Board with id ${id}`);
    }

    return found;
  }

  // id로 subform 데이터를 검색 후 삭제
  async deleteSubFormInfo(id: number): Promise<boolean> {
    const result: DeleteResult = await this.delete(id);

    // 만약 데이터베이스에 변경사항이 없다면 
    // 제거되지 않은 것이므로 false 반환 아니라면 true
    if (result.affected === 0) {
      return false;
    }

    return true;
  }

  // 관리자가 특정 id의 정보 변경을 목적으로 subform_info 데이터를 JSON으로 넘겨주고
  // 데이터베이스에서 id 정보를 확인 후 데이터 변경 -> 저장
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
