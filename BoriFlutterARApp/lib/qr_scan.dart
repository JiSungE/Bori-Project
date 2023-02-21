// ignore_for_file: use_build_context_synchronously

import 'dart:async';
import 'package:ar_view/route.dart';
import 'package:flutter/material.dart';
import 'package:qrscan/qrscan.dart' as scanner;

import 'main.dart';

class QrScanner extends StatefulWidget {
  const QrScanner({super.key});

  @override
  _QrScannerState createState() => _QrScannerState();
}

class _QrScannerState extends State<QrScanner> {
  @override
  initState() {
    super.initState();
    _scan();
  }

  Widget home() {
    Future.delayed(const Duration(seconds: 1, microseconds: 100), () {});
    return const Text('Loading...');
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        backgroundColor: Colors.grey[300],
        body: Builder(
          builder: (BuildContext context) {
            return SizedBox.shrink(
              child: home(),
            );
          },
        ),
      ),
    );
  }

  //비동기 함수
  Future _scan() async {
    //스캔 시작 - 이때 스캔 될때까지 blocking
    String? scanString = await scanner.scan();
    Future.delayed(const Duration(seconds: 1, microseconds: 100), () {
      if (scanString == 'W19') {
        tempObject =
            'https://wsggbucket.s3.ap-northeast-2.amazonaws.com/nonLight.glb';
        tempState = 2;
        Navigator.pushReplacement(
            context,
            MaterialPageRoute(
              builder: (context) => const PlanesRoute(),
            ));
      }
    });
  }
}
