/* eslint-disable prettier/prettier */
import { Body, Controller, Get, ParseIntPipe, Post } from '@nestjs/common';
import { BorimapService } from './borimap.service';
import { marker_info } from './Entity/MarkerInfo.entity';

@Controller('borimap')
export class BorimapController {
  constructor(private boriMapService: BorimapService) {}
  
  // 모든 마커 정보를 가져오는 기능
  @Get()
  getAllMarkers(): Promise<marker_info[]> {
    return this.boriMapService.getAllMarkers();
  }

  // JSON으로 넘어온 마커의 id값을 통해 마커를 찾아내는 기능
  @Post('/getmarker')
  getMarker(@Body('id', ParseIntPipe) id: number): Promise<marker_info> {
    return this.boriMapService.getMarker(id);
  }
}
