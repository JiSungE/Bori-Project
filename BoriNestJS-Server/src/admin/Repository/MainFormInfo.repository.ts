/* eslint-disable prettier/prettier */
import { CustomRepository } from 'src/Custom/typeorm-ex.decorator';
import { DeleteResult, Repository } from 'typeorm';
import { mainform_info } from '../Entity/Mainform.entity';
import { CreateMainFormInfoDto } from '../Dto/CreateMainFormInfo.dto';

@CustomRepository(mainform_info)
export class MainFormInfoRepository extends Repository<mainform_info> {
  /*
    MarkerInfo테이블에 모든 마커 정보를 가져오는 함수
  */
  async getAllMainForm(): Promise<mainform_info[]> {
    return await this.find();
  }

  // 메인 이미지 정보를 관리자에게 JSON 형태로 받아 저장
  async createMainFormInfo(
    createMainFormInfoDto: CreateMainFormInfoDto,
  ): Promise<mainform_info> {
    const { img, imgurl }: CreateMainFormInfoDto = createMainFormInfoDto;
    const mainform = this.create({
      img,
      imgurl,
    });
    await this.save(mainform);
    return mainform;
  }

  // id를 통해 메인 이미지 정보를 삭제
  async deleteMainFormInfo(id: number): Promise<boolean> {
    const result: DeleteResult = await this.delete(id);

    // 만약 데이터베이스에 변경사항이 없다면 
    // 제거되지 않은 것이므로 false 반환 아니라면 true
    if (result.affected === 0) {
      return false;
    }

    return true;
  }
}
