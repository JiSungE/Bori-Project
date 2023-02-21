/* eslint-disable prettier/prettier */
/* eslint-disable prefer-const */
import { CustomRepository } from 'src/Custom/typeorm-ex.decorator';
import { marker_info } from 'src/borimap/Entity/MarkerInfo.entity';
import { DeleteResult, Repository } from 'typeorm';
import { CreateMarkerInfoDto } from '../Dto/CreateMarkerInfo.dto';
import { NotFoundException } from '@nestjs/common';

@CustomRepository(marker_info)
export class AdminMarkerRepository extends Repository<marker_info> {
  /*
    CreateMarkerInfoDto를 사용하여 MarkerInfo 테이블에 데이터 등록
  */
  async createMarkerInfo(
    createMakerInfoDto: CreateMarkerInfoDto,
  ): Promise<marker_info> {
    let {
      name,
      imgname,
      address,
      description,
      tag,
      latitude,
      longtitude,
    }: CreateMarkerInfoDto = createMakerInfoDto;
    if (!imgname.includes('http'))
      //만약관리자가 직접 이미지 전체의 사이트를 가져올때의 작업
      imgname = `https://wsggbucket.s3.ap-northeast-2.amazonaws.com/${imgname}.jpg`;

    const marker = this.create({
      name,
      imgname,
      address,
      description,
      tag,
      latitude,
      longtitude,
    });

    await this.save(marker);
    return marker;
  }

  /*
    MarkerInfo 테이블에서 id를 검색 후
    id가 일치하는 Marker를 테이블에서 삭제
  */
  async deleteMarkerInfo(id: number): Promise<boolean> {
    const result: DeleteResult = await this.delete(id);
    if (result.affected === 0) {
      return false;
    }

    return true;
  }

  async getAllMarker(): Promise<marker_info[]> {
    return await this.find();
  }

  async getMarkerById(id: number): Promise<marker_info> {
    const found = await this.findOne({ where: { id } });

    if (!found) {
      throw new NotFoundException(`Can't find Board with id ${id}`);
    }

    return found;
  }

  async updateMarkerInfo(updateMarkerInfo: marker_info): Promise<marker_info> {
    const marker: marker_info = await this.getMarkerById(updateMarkerInfo.id);
    marker.name = updateMarkerInfo.name;
    marker.imgname = updateMarkerInfo.imgname;
    marker.address = updateMarkerInfo.address;
    marker.description = updateMarkerInfo.description;
    marker.tag = updateMarkerInfo.tag;
    marker.latitude = updateMarkerInfo.latitude;
    marker.longtitude = updateMarkerInfo.longtitude;

    await this.save(marker);
    return marker;
  }
}
