import 'package:ar_view/sun_flower.dart';
import 'package:flutter/material.dart';
import 'location_ar.dart';
import 'object_on_planes_view.dart';

// GPS 정보에 3D 오브젝트를 띄어놓는 위젯
class LocationRoute extends StatelessWidget {
  const LocationRoute({super.key});

  @override
  Widget build(BuildContext context) {
    return const Scaffold(
      body: LocationAR(),
    );
  }
}

// 바닥을 인식하여 ARObject를 띄우는 위젯
class PlanesRoute extends StatelessWidget {
  const PlanesRoute({super.key});

  @override
  Widget build(BuildContext context) {
    return const Scaffold(
      body: ObjectGesturesWidget(),
    );
  }
}

// 홈 위젯
class SunFlowerRoute extends StatelessWidget {
  const SunFlowerRoute({super.key});

  @override
  Widget build(BuildContext context) {
    return const Scaffold(
      body: Sunflower(),
    );
  }
}
