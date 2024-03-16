import 'package:daer_diary/entities/photo_memory.dart'
import 'package:flutter/cupertino.dart';

class PhotoMemoryWidget extends StatelessWidget {
  PhotoMemoryWidget ({super.key, required this.photoMemory});
  final PhotoMemory photoMemory;

  @override
  Widget build (BuildContext context) {
    return Column(children: [
      Text(photoMemory.date.toString(), style: TextStyle(fontSize: 22, fontWeight: FontWeight.bold),
      ), //text
      Text(photoMemory.filePath),
      Text(photoMemory.text)
    ],
    ); //column
  }
}

// Positional argument
// class Test extends StatelessWidget {
//   const Test({super.key});
//
//   @override
//   Widget build(BuildContext context){
//     //return PhotoMemoryWidget(photoMemory: photoMemory, key: Key('test'))
//
//     //Positional argument
//     return PhotoMemoryWidget('test', photoMemory: PhotoMemory())
//   }
// }