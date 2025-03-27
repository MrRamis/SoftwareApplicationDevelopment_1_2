import 'dart:io';
import 'dart:math';

void main() {
  var list = List.generate(
    15,
    (int index) => (Random().nextInt(31) % 31 - 15),
    growable: true,
  );
  print(
    "\n1) Программа для вычисления значения выражения:"
    "\n2) Программа для вывода на экран сообщения о том, есть ли среди чисел ,  хотя бы одна пара взаимно противоположных чисел."
    "\n3) Программа для вывода на экран сообщения о том, является ли сумма цифр данного числа  нечетным числом, при этом либо меньшим 12, либо большим 36."
    "\n4) Программа для вычисления значения выражения:"
    """\n5) Программа, выполняющая следующие действия:
    а) Ввод пользователем с клавиатуры количества строк и столбцов прямоугольной матрицы.
  б) Заполнение матрицы целыми псевдослучайными числами (например, из диапазона [-100; 100]).
  в) Вывод на экран заполненной матрицы.
  г) Поиск и вывод на экран суммы элементов строки, в которой расположен элемент с наименьшим значением, а также индекса этой строки и значения данного элемента."""
    "\n6) Выход",
  );
  while (true) {
    print("Введите команду: ");
    String? command = stdin.readLineSync();
    switch (command) {
      case "1":
        case1();
      case "2":
        case2();
      case "3":
        case3();
      case "4":
        case4();
      case "5":
        case5();
      case "6":
        for (int i = 0; i < list.length; i++) {
          if (i % 2 != 0) list[i + 1] = 100;
        }
        print(list);
      case "7":
        exit(0);
      default:
        print("Непонятная команда!");
    }
  }
}

void case1() {
  print("Ведите: x");
  var xS = stdin.readLineSync();
  print("Ведите: y");
  var yS = stdin.readLineSync();
  print("Ведите: z");
  var zS = stdin.readLineSync();
  var x = double.tryParse(xS!);
  var y = double.tryParse(yS!);
  var z = double.tryParse(zS!);
  if (x != null && y != null && z != null) {
    print("Ответ: ");
    print(pow((((6) / (x - 0.75 * y)) + ((5 * y) / (1 - z))), 0.25));
  } else {
    print("Введены не цифры");
  }
}

void case2() {
  print("Ведите: a");
  var aS = stdin.readLineSync();
  print("Ведите: b");
  var bS = stdin.readLineSync();
  print("Ведите: c");
  var cS = stdin.readLineSync();
  var a = double.tryParse(aS!);
  var b = double.tryParse(bS!);
  var c = double.tryParse(cS!);
  if (a != null && b != null && c != null) {
    if (a + b == 0 || a + c == 0 || b + c == 0) {
      print("Есть пара взаимно противоположных чисел");
    } else
      print("Нет пары взаимно противоположных чисел");
  } else {
    print("Введены не цифры");
  }
}

void case3() {
  print("Ведите: a");
  var aS = stdin.readLineSync();
  print("Ведите: b");
  var bS = stdin.readLineSync();
  print("Ведите: c");
  var cS = stdin.readLineSync();
  var a = double.tryParse(aS!);
  var b = double.tryParse(bS!);
  var c = double.tryParse(cS!);
  if (a != null && b != null && c != null) {
    if (a + b == 0 || a + c == 0 || b + c == 0) {
      print("Есть пара взаимно противоположных чисел");
    } else
      print("Нет пары взаимно противоположных чисел");
  } else {
    print("Введены не цифры");
  }
}

void case4() {
  print("вещественное число: a");
  var aS = stdin.readLineSync();
  print("целое число: n");
  var nS = stdin.readLineSync();

  var a = double.tryParse(aS!);
  var n = int.tryParse(nS!);

  if (a != null && n != null) {
    if (!(n <= 1)) {
      double sum = 0;
      for (int i = 0; i < n; i++) {
        sum += 1 / pow(a, 2 * i - 2);
      }
      print(sum);
    } else {
      print("Исходные данные не верны!");
    }
  } else {
    print("Введены не цифры");
  }
}

void case5() {
  print("количества строк");
  var aS = stdin.readLineSync();
  print("количества столбцов");
  var nS = stdin.readLineSync();

  var a = int.tryParse(aS!);
  var n = int.tryParse(nS!);

  if (a != null && n != null) {
    final _random = new Random();
    List<List<int>> matrix = [];
    for (int j = 0; j < a; j++) {
      List<int> row = [];
      for (int k = 0; k < n; k++) {
        int next(int min, int max) => min + _random.nextInt(max - min);
        row.add(next(-100, 100));
      }
      matrix.add(row);
    }
    for (var plane in matrix) {
      print(plane);
      print('');
    }
    Map<int, int> map = {};
    for (int k = 0; k < a; k++) {
      map[k] = matrix[k].reduce(min);
    }
    late int key;
    map.forEach((keyL, value) {
      if (value == map.values.reduce(min)) key = keyL;
    });
    print("суммы элементов строки");
    print( matrix[key].reduce((value, current) => value + current));
    print("индекса данной строки");
    print( key);
    print("значения данного элемента");
    print( matrix[key].reduce(min));
  } else {
    print("Введены не цифры");
  }
}