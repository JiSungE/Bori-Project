// location_ar.dart

import 'package:ar_view/main.dart';
import 'package:ar_view/route.dart';
import 'package:flutter/material.dart';
import 'package:ar_location_view/ar_location_view.dart';
import 'package:geolocator/geolocator.dart';
import 'package:sensors_plus/sensors_plus.dart';
import 'annotation_view.dart';
import 'annotations.dart';

bool positionTemp = true;

class LocationAR extends StatefulWidget {
  const LocationAR({super.key});

  @override
  State<LocationAR> createState() => _LocationARState();
}

class _LocationARState extends State<LocationAR> {
  // LocationAR 객체들이 담겨있는 리스트
  List<Annotation> annotations = [];
  // GyroSensor 데이터를 담는 x, y, z 변수
  // 생성자
  _LocationARState();

  @override
  void initState() {
    // GyroSensor를 주기적으로 호출하는 함수
    gyroscopeEvents.listen((GyroscopeEvent event) {
      if (tempState == 1) {
        if (event.x < -2) {
          if (tempName == AnnotationType.w19) {
            tempObject =
                'https://wsggbucket.s3.ap-northeast-2.amazonaws.com/nonLight.glb';
            if (tempState == 2) {
              return;
            }
            Navigator.pop(context);
            tempState = 2;
            Navigator.pushReplacement(
                context,
                MaterialPageRoute(
                  builder: (context) => const PlanesRoute(),
                ));
          }
        }
      }
    });
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: ArLocationWidget(
          showRadar: false,
          annotations: annotations,
          showDebugInfoSensor: false,
          annotationViewBuilder: (context, annotation) {
            return AnnotationView(
              key: ValueKey(annotation.uid),
              annotation: annotation as Annotation,
            );
          },
          onLocationChange: (Position position) {
            debugPrint(
                'current=> latitude: ${position.latitude} longtitude: ${position.longitude}');
            Future.delayed(const Duration(seconds: 0, microseconds: 100), () {
              annotations =
                  getBuildingAnnotation(position: position, numberMaxPoi: 50);
              setState(() {});
            });
          },
        ),
      ),
    );
  }
}
