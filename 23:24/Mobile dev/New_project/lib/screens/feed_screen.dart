import 'package:flutter/cupertino.dart';
import '../entities/photo_memory.dart';

List<PhotoMemory> demolist = [
  PhotoMemory(DateTime.now(), 'Image 1 caption', 'Image 1 path'),
  PhotoMemory(DateTime.now(), 'Image 2 caption', 'Image 2 path'),
];

class FeedScreen extends StatelessWidget {
  const FeedScreen({super.key});
}

@override
  Widget build(BuildContext context){

  // List<PhotoMemoryWidget> getPhotoMemories(){
  //   List<PhotoMemoryWidget> p = [];
  //   for(var i = 1; i < demoList.lenght; i++) {
  //     p.add(PhotoMemoryWidget(photoMemory; demoList[i]))
  //   }
  //   return p;
  // }

    return scaffold(
      body: SafeArea(
        children: SingleChildScrollView(
          child: Column(
            children:
          )
        )
            .map((photoMemory) => PhotoMemoryWidget(photoMemory: photoMemory))
            .toList(),
      )
    );
  }
}