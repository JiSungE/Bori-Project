// ignore_for_file: unused_field

import 'package:ar_view/route.dart';
import 'package:flutter/material.dart';

import 'annotations.dart';

int tempState = 0;
String tempObject =
    'https://wsggbucket.s3.ap-northeast-2.amazonaws.com/nonLight.glb';
AnnotationType? tempName = AnnotationType.w19;
void main() {
  runApp(const MyRoot());
}

class MyRoot extends StatefulWidget {
  const MyRoot({super.key});

  @override
  State<MyRoot> createState() => _MyRootState();
}

class _MyRootState extends State<MyRoot> {
  @override
  Widget build(BuildContext context) {
    return const MaterialApp(
      home: Scaffold(
        body: SunFlowerRoute(),
      ),
    );
  }
}
////////////////
// // QR코드 생성 위젯
// MaterialApp(
//       home: Scaffold(
//           body: Column(children: <Widget>[
//         const SizedBox(
//           height: 300,
//         ),
//         QrImage(
//           data: 'W19',
//           backgroundColor: Colors.white,
//           size: 200,
//         )
//       ])),
//     );
