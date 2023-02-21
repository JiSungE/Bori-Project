import 'package:ar_view/qr_scan.dart';
import 'package:ar_view/route.dart';
import 'package:flutter/material.dart' hide Intent;
import 'dart:math' as math;

import 'package:receive_intent/receive_intent.dart';

const Color primaryColor = Color.fromARGB(255, 0, 221, 255);
const TargetPlatform platform = TargetPlatform.android;

class Sunflower extends StatefulWidget {
  const Sunflower({super.key});

  @override
  State<StatefulWidget> createState() {
    return _SunflowerState();
  }
}

class _SunflowerState extends State<Sunflower> {
  double seeds = 100.0;
  String? getIntentData;
  // late Intent _initialIntent;

  int get seedCount => seeds.floor();

  // Future<void> _initReceiveIntent() async {
  //   // Platform messages may fail, so we use a try/catch PlatformException.
  //   try {
  //     final receivedIntent = await ReceiveIntent.getInitialIntent();
  //     getIntentData = receivedIntent;
  //   } on PlatformException {
  //     debugPrint('Faild');
  //   }
  //   setState(() {});
  // }

  @override
  void initState() {
    super.initState();
    _init();
  }

  Future<void> _init() async {
    final receivedIntent = await ReceiveIntent.getInitialIntent();

    if (!mounted) return;
    // Navigator.push(context, MaterialPageRoute(builder: (context) {
    //   return const LocationRoute();
    // }));
    // setState(() {
    //   _initialIntent = receivedIntent!;
    // });
  }

  Widget _buildFromIntent(String label, Intent? intent) {
    // debugPrint('data: ${intent?.data}');
    getIntentData = intent?.data;

    if (getIntentData == 'ggapp://action?data=0') {
      Future.delayed(const Duration(seconds: 0, microseconds: 100), () {
        Navigator.push(context, MaterialPageRoute(builder: (context) {
          return const LocationRoute();
        }));
      });
    } else if (getIntentData == 'ggapp://action?data=1') {
      Future.delayed(const Duration(seconds: 0, microseconds: 100), () {
        Navigator.push(context, MaterialPageRoute(builder: (context) {
          return const QrScanner();
        }));
      });
    }
    return const Text("");
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: ThemeData().copyWith(
        platform: platform,
        brightness: Brightness.dark,
        sliderTheme: SliderThemeData.fromPrimaryColors(
          primaryColor: primaryColor,
          primaryColorLight: primaryColor,
          primaryColorDark: primaryColor,
          valueIndicatorTextStyle: const DefaultTextStyle.fallback().style,
        ),
      ),
      home: Scaffold(
        body: Container(
          constraints: const BoxConstraints.expand(),
          decoration:
              BoxDecoration(border: Border.all(color: Colors.transparent)),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Center(
                  child: Row(
                children: [
                  Center(
                    child: Column(children: [
                      // _buildFromIntent("INITIAL", _initialIntent),
                      StreamBuilder<Intent?>(
                        stream: ReceiveIntent.receivedIntentStream,
                        builder: (context, snapshot) =>
                            _buildFromIntent("STREAMED", snapshot.data),
                      ),
                    ]),
                  )
                ],
              )),
              Container(
                decoration: BoxDecoration(
                    border: Border.all(color: Colors.transparent)),
                child: SizedBox(
                  width: 500,
                  height: 400,
                  child: CustomPaint(
                    painter: SunflowerPainter(seedCount),
                  ),
                ),
              ),
              Text("보이는 점 갯수: $seedCount"),
              ConstrainedBox(
                constraints: const BoxConstraints.tightFor(width: 300),
                child: Slider.adaptive(
                  min: 20,
                  max: 2000,
                  value: seeds,
                  onChanged: (newValue) {
                    setState(() {
                      seeds = newValue;
                    });
                  },
                ),
              ),
            ],
          ),
        ),
      ),

      // Padding(
      //   padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 20),
      //   child: Column(
      //     mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      //     children: [
      //       _buildFromIntent("INITIAL", _initialIntent),
      //       StreamBuilder<Intent?>(
      //         stream: ReceiveIntent.receivedIntentStream,
      //         builder: (context, snapshot) =>
      //             _buildFromIntent("STREAMED", snapshot.data),
      //       )
      //     ],
      //   ),
      // ),
    );
  }
}

class SunflowerPainter extends CustomPainter {
  static const seedRadius = 2.0;
  static const scaleFactor = 4;
  static const tau = math.pi * 2;

  static final phi = (math.sqrt(5) + 1) / 2;

  final int seeds;

  SunflowerPainter(this.seeds);

  @override
  void paint(Canvas canvas, Size size) {
    var center = size.width / 2;

    for (var i = 0; i < seeds; i++) {
      var theta = i * tau / phi;
      var r = math.sqrt(i) * scaleFactor;
      var x = center + r * math.cos(theta);
      var y = center - r * math.sin(theta);
      var offset = Offset(x, y);
      if (!size.contains(offset)) {
        continue;
      }
      drawSeed(canvas, x, y);
    }
  }

  @override
  bool shouldRepaint(SunflowerPainter oldDelegate) {
    return oldDelegate.seeds != seeds;
  }

  // Draw a small circle representing a seed centered at (x,y).
  void drawSeed(Canvas canvas, double x, double y) {
    var paint = Paint()
      ..strokeWidth = 2
      ..style = PaintingStyle.fill
      ..color = primaryColor;
    canvas.drawCircle(Offset(x, y), seedRadius, paint);
  }
}
