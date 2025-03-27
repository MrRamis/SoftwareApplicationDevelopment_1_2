import 'dart:io';
import 'str/sea.dart';
import 'str/waterfall.dart';

void main() {
  instruction();
  List<Sea> listSea = [];
  List<Waterfall> listWaterfall = [];
  while(true){
    String? command = stdin.readLineSync();
    entering_sea(listSea);
    switch(command)
    {
      case "1":
        instruction();
      case "2":
        entering_waterfall(listWaterfall);
      case "3":
        entering_sea(listSea);
      case "4":
        print_list(listSea, listWaterfall);
      case "5":
        sort(listSea, listWaterfall);
      case "6":
        exit(0);
      default:
        print("Непонятная команда!");
    }
  }
}
void instruction(){
  print("Команды:"
      "\nсправка: 1"
      "\nВвести моря: 2"
      "\nВвести горы: 3"
      "\nВывести все элементы масивов: 4"
      "\nСортировать массивы: 5"
      "\nВыход из программы: 6");
}
void sort(List<Sea> listSea,List<Waterfall> listWaterfall){
  sort_sea(listSea);
  sort_waterfall(listWaterfall);
  print_list(listSea,listWaterfall);
}
void sort_sea(List<Sea> listSea){
  listSea.sort((a, b) => a.name.length.compareTo(b.name.length));
}
void sort_waterfall(List<Waterfall> listWaterfall){
  listWaterfall.sort((a, b) => a.height.compareTo(b.height));
}
void entering_sea(List<Sea> listSea){
  bool isEntering = true;
  print("Команды:"
      "\nВыход из добавления: 1"
      "\nДобавить моря: 2"
  );
  while (isEntering) {
    String? command = stdin.readLineSync();
    switch (command) {
      case "1":
        isEntering = false;
      case "2":
        {
          print("Название моря");
          String? name = stdin.readLineSync();
          print("название океан");
          String? ocean = stdin.readLineSync();
          print("Какая площадь");
          String? square = stdin.readLineSync();
          var squareD = double.tryParse(square!);
          if (squareD != null && name != null && ocean != null) {
            listSea.add(new Sea(name,squareD, ocean));
          } else {
            print("Какоето поле введено не правильно");
          }
        }
      default:
        print("Непонятная команда!");
    }
  }
}
void entering_waterfall(List<Waterfall> listWaterfall){
  bool isEntering = true;
  print("Команды:"
      "\nВыход из добавления: 1"
      "\nДобавить водопад: 2"
  );
  while (isEntering) {
    String? command = stdin.readLineSync();
    switch (command) {
      case "1":
        isEntering = false;
      case "2":
        {
          print("Название водопада");
        String? name = stdin.readLineSync();
        print("название страны");
        String? country = stdin.readLineSync();
        print("Какая высота");
        String? height = stdin.readLineSync();
          var heightD = double.tryParse(height!);
          if (heightD != null && name != null && country != null) {
            listWaterfall.add(new Waterfall(name,heightD, country));
          } else {
            print("Какоето поле введено не правильно");
          }
      }
      default:
        print("Непонятная команда!");
    }
  }
}
void print_list(List<Sea> listSea, List<Waterfall> listWaterfall){
  print(listSea);
  print("\n");
  print(listWaterfall);
}