import 'dart:io';

import 'receip.dart';

void main() {
  List<Receip> listReceip = [];
  listReceip.add(new Receip());
  listReceip.add(new Receip());
  listReceip.add(new Receip());
  listReceip.add(new Receip());
  listReceip.add(new Receip());
  listReceip.add(new Receip());
  listReceip.add(new Receip());

  while(true){
    String? command = stdin.readLineSync();

    switch(command)
    {
      case "1":

      case "2":

      case "3":
        listReceip.forEach((e)=> e.show());
      case "4":
        //double maxSum = listReceip.ma
       // listReceip.where((e) => e.getSum() < listRecei);
      case "5":
      listReceip.where((e)=> e.getDate().toString().contains(RegExp(r'[158]'))).forEach((e)=>e.show());
      case "6":
        exit(0);
      default:
        print("Непонятная команда!");
    }
  }
}