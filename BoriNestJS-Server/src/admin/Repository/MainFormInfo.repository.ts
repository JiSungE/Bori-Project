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

  async deleteMainFormInfo(id: number): Promise<boolean> {
    const result: DeleteResult = await this.delete(id);
    if (result.affected === 0) {
      return false;
    }

    return true;
  }
}
