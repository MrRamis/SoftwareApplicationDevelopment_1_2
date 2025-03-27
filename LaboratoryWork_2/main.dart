import 'dart:io';

import 'receip.dart';

void main() {
  List<Receip> listReceip = [];
  //  listReceip.add(new Receip());
  // listReceip.add(new Receip());
  // listReceip.add(new Receip());
  // listReceip.add(new Receip());
  // listReceip.add(new Receip());
  // listReceip.add(new Receip());
  // listReceip.add(new Receip());
  print(
    """1) Количество объектов и значения переменных экземпляра каждого объекта пользователь вводит с клавиатуры.   
2) Выводится на экран количество созданных объектов с использованием соответствующего статического метода.
3) выводится информация обо всех объектах.
4) выводится информация об объектах, удовлетворяющих первому условию.
5) выводится информация об объектах, удовлетворяющих второму условию.
6) Выход.
""",
  );
  while (true) {
    String? command = stdin.readLineSync();
    switch (command) {
      case "1":
        _addReceip(listReceip);
      case "2":
        if (!listReceip.isEmpty) print(listReceip[0].getCount());
      case "3":
        if (!listReceip.isEmpty) listReceip.forEach((e) => e.show());
      case "4":
        if (!listReceip.isEmpty) {
          double maxSum = 0.0;
          listReceip.forEach((n) {
            if (n.getSum() > maxSum) maxSum = n.getSum();
          });
          print(maxSum);
          listReceip.where((e) => e.getSum() < maxSum).forEach((e) => e.show());
        }
      case "5":
        if (listReceip.isEmpty)
          listReceip
              .where((e) => e.getDate().toString().contains(RegExp(r'[158]')))
              .forEach((e) => e.show());
      case "6":
        exit(0);
      default:
        print("Непонятная команда!");
    }
  }
}

void _addReceip(List<Receip> listReceip) {
  print("Ведите: количество добовляемых квинтанций");
  var countS = stdin.readLineSync();
  var count = double.tryParse(countS!);
  if (count != null) {
    for (var i = 0; i < count; i++) {
      print("Ведите: номер квинтации");
      var numberS = stdin.readLineSync();
      var number = int.tryParse(numberS!);
      print("Ведите: дату ГГГГ-ММ-ДД ЧЧ:ММ:СС.МЛС");
      var dateS = stdin.readLineSync();
      var date = DateTime.tryParse(dateS!);
      print("Ведите: сумму");
      var sumS = stdin.readLineSync();
      var sum = double.tryParse(sumS!);
      if (number != null && date != null && sum != null) {
        listReceip.add(new Receip.p(number, date, sum));
      } else {
        print("Какоето поле введено не правильно");
      }
    }
  } else {
    print("Введены не количество обектов");
  }
}
