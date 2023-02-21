// annotations.dart

import 'package:ar_location_view/ar_annotation.dart';
import 'package:flutter/material.dart';
import 'package:geolocator/geolocator.dart';
import 'package:uuid/uuid.dart';

enum AnnotationType { w19, w2, w3 }

class Annotation extends ArAnnotation {
  final AnnotationType type;

  Annotation({required super.uid, required super.position, required this.type});
}

AnnotationType getAnnotationName() {
  final types = AnnotationType.values.toList();
  return types[0];
}

List<Annotation> getBuildingAnnotation(
    {required Position position, int distance = 1500, int numberMaxPoi = 10}) {
  debugPrint("latitude: ${position.latitude}");
  debugPrint("longtitude: ${position.longitude}");

  return List<Annotation>.generate(
    1,
    (index) {
      return Annotation(
        uid: const Uuid().v1(),
        position: getLocation(
          36.336215294831085,
          127.44562138569502,
          distance / 100000,
          distance / 100000,
        ),
        type: getAnnotationName(),
      );
    },
  );
}

Position getLocation(double centerLatitude, double centerLongitude,
    double deltaLat, double deltaLon) {
  var lat = centerLatitude;
  var lon = centerLongitude;

  // final latDelta = -(deltaLat / 2) + Random.secure().nextDouble() * deltaLat;
  // final lonDelta = -(deltaLon / 2) + Random.secure().nextDouble() * deltaLon;

  return Position(
    longitude: lon,
    latitude: lat,
    timestamp: DateTime.now(),
    accuracy: 1,
    altitude: 1,
    heading: 1,
    speed: 1,
    speedAccuracy: 1,
  );
}
