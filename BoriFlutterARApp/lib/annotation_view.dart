// annotation_view.dart

import 'package:ar_view/main.dart';
import 'package:flutter/material.dart';

import 'annotations.dart';

class AnnotationView extends StatelessWidget {
  final Annotation annotation;
  const AnnotationView({
    Key? key,
    required this.annotation,
  }) : super(key: key);

  String _getAnnotationTitle(dynamic type, dynamic distance) {
    return '${annotation.type.toString().substring(15)}-${annotation.distanceFromUser.toInt()}m';
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(5),
        color: Colors.white,
      ),
      child: Row(
        children: [
          Expanded(
            child: Container(
              decoration: const BoxDecoration(
                borderRadius: BorderRadius.only(
                  topLeft: Radius.circular(5),
                  bottomLeft: Radius.circular(5),
                ),
              ),
              child: typeFactory(annotation.type),
            ),
          ),
          Expanded(
              child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              SingleChildScrollView(
                child: Column(
                  children: [
                    Text(
                      _getAnnotationTitle(
                          annotation.type.toString().substring(15),
                          annotation.distanceFromUser.toInt()),
                      maxLines: 1,
                      style: const TextStyle(fontWeight: FontWeight.bold),
                    ),
                    ElevatedButton(
                      child: const Text('클릭'),
                      onPressed: () {
                        tempState = 1;
                        tempName = annotation.type;
                        showDialog(
                            context: context,
                            builder: (context) {
                              return Dialog(
                                  child: Stack(
                                children: <Widget>[
                                  SizedBox.expand(
                                    child: Image.network(
                                      'https://wsggbucket.s3.ap-northeast-2.amazonaws.com/Endi.png',
                                      fit: BoxFit.fill,
                                    ),
                                  ),
                                  Container(
                                    margin: const EdgeInsets.only(top: 100),
                                    padding: const EdgeInsets.only(bottom: 5),
                                    child: Align(
                                      alignment: Alignment.bottomCenter,
                                      child: Row(
                                        mainAxisAlignment:
                                            MainAxisAlignment.spaceEvenly,
                                        children: <Widget>[
                                          ElevatedButton(
                                            onPressed: () {
                                              Navigator.pop(context);
                                              tempState = 0;
                                            },
                                            child: const Text('닫기'),
                                          )
                                        ],
                                      ),
                                    ),
                                  )
                                ],
                              ));
                            });
                      },
                    )
                  ],
                ),
              ),
            ],
          ))
        ],
      ),
    );
  }

  Widget typeFactory(AnnotationType type) {
    IconData iconData = Icons.ac_unit_outlined;
    Color color = Colors.teal;
    switch (type) {
      case AnnotationType.w19:
        iconData = Icons.local_pharmacy_outlined;
        color = Colors.red;
        break;
      case AnnotationType.w2:
        iconData = Icons.hotel_outlined;
        color = Colors.green;
        break;
      case AnnotationType.w3:
        iconData = Icons.library_add_outlined;
        color = Colors.blue;
        break;
    }
    return Image.network(
        'https://wsggbucket.s3.ap-northeast-2.amazonaws.com/W19.png');
  }
}
