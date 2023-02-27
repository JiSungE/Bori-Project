/* eslint-disable prettier/prettier */
import { Injectable } from '@nestjs/common';
import { CreateMarkerInfoDto } from './Dto/CreateMarkerInfo.dto';
import { AdminMarkerRepository } from './Repository/AdminMarker.repository';
import { marker_info } from 'src/borimap/Entity/MarkerInfo.entity';
import { MainFormInfoRepository } from './Repository/MainFormInfo.repository';
import { mainform_info } from './Entity/Mainform.entity';
import { subform_info } from './Entity/Subform.entity';
import { SubFormInfoRepository } from './Repository/SubFormInfo.repository';

@Injectable()
export class AdminService {
  constructor(
    private adminMarkerRepository: AdminMarkerRepository,
    private mainformInfoRepository: MainFormInfoRepository,
    private subformInfoRepository: SubFormInfoRepository,
  ) {}

  /*
    createMarkerInfoDto를 마커를 등록하는
    저장소 함수에 보내주는 함수
  */
  createMarkerInfo(
    createMakerInfoDto: CreateMarkerInfoDto,
  ): Promise<marker_info> {
    return this.adminMarkerRepository.createMarkerInfo(createMakerInfoDto);
  }

  getMarkerById(id: number): Promise<marker_info> {
    return this.adminMarkerRepository.getMarkerById(id);
  }

  updateMarkerInfo(updateMarkerInfo: marker_info): Promise<marker_info> {
    return this.adminMarkerRepository.updateMarkerInfo(updateMarkerInfo);
  }

  /*
    id를 받아서
    MarkerInfo테이블에 일치하는 id를 삭제해주는
    저장소 파일에 데이터를 보내주는 함수
  */
  deleteMarkerInfo(id: number): Promise<boolean> {
    return this.adminMarkerRepository.deleteMarkerInfo(id);
  }

  //region mainform
  getAllMainForm(): Promise<mainform_info[]> {
    return this.mainformInfoRepository.getAllMainForm();
  }

  createMainFormInfo(createMainFormInfoDto): Promise<mainform_info> {
    return this.mainformInfoRepository.createMainFormInfo(
      createMainFormInfoDto,
    );
  }

  deleteMainFormInfo(id: number): Promise<boolean> {
    return this.mainformInfoRepository.deleteMainFormInfo(id);
  }
  //endregion

  //region subform
  getAllSubForm(): Promise<subform_info[]> {
    return this.subformInfoRepository.getAllMainForm();
  }

  createSubFormInfo(createSubFormInfoDto): Promise<subform_info> {
    return this.subformInfoRepository.createSubFormInfo(createSubFormInfoDto);
  }

  getSubFormById(id: number): Promise<subform_info> {
    return this.subformInfoRepository.getSubFormById(id);
  }

  updateSubFormInfo(updateSubFormInfo: subform_info): Promise<subform_info> {
    return this.subformInfoRepository.updateSubFormInfo(updateSubFormInfo);
  }

  deleteSubFormInfo(id: number): Promise<boolean> {
    return this.subformInfoRepository.deleteSubFormInfo(id);
  }
  //endregion
}
