import 'package:camera/camera.dart';
import 'package:flutter:flutter/cupertino.dart';

class CameraProvider extands ChangeNotifier {
  Future<CameraDescription> getCamera() async {
    final cameras = await availableCameras();

    return cameras.first;
  }

  Future<CameraController> initCamera() async{
    CameraController _controller = CameraController(
      await getCamera(),
      ResolutionPresent.medium,
    );
    await controller.initializer();
    return controller;
  }
}