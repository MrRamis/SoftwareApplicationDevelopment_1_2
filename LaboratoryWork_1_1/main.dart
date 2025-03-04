import 'dart:io';
import 'dart:math';

void main() {
  var list = List.generate(15, (int index) => (Random().nextInt(31)%31 - 15), growable: true);
print("\n1) Формирование массива (случайные числа) A[15]"
    "\n2) Поиск суммы и количества отрицательных на четных местах"
    "\n3) Поиск максимального из кратных 3, стоящих на нечетных местах"
    "\n4) Сортировка по возрастанию"
    "\n5) Удаление элементов, кратных 5"
    "\n6) Вставка после каждого нечетного элемента числа 100"
    "\n7) Выход");
  while(true){
    print("Введите команду: ");
    String? command = stdin.readLineSync();
    switch(command)
    {
      case "1":
        list = List.generate(15, (int index) => (Random().nextInt(31)%31 - 15), growable: true);
        print(list);
      case "2":
        int sum = 0;
        int negative = 0;
        for(int i=0 ;i < list.length;i++){
          if(i%2 != 0 && list[i]%3 == 0){
            sum+=list[i];
            negative++;
          }
        }
        print("Сумма: $sum; Количество отрицательных чисел: $negative;");
        print(list);
      case "3":
        int maxIndex  = 0;
        for(int i=0 ;i < list.length;i++){
          if(i%2 != 0 && list[i] < 0)
            if (list[maxIndex] < list[i])
            {
              maxIndex = i;
            }
            else if (maxIndex == 0)
            {
              maxIndex = i;
            };
        }
        if (maxIndex != 0)
        {
          print("Максимальное число кратным трем: "+list[maxIndex].toString());
        }
        else
        {
            print("Нету такого числа");
        }
        print(list);
      case "4":
        list.sort();
        print(list);
      case "5":
         list.removeWhere((item) => item % 5 == 0);
         print(list);
      case "6":
        for(int i=0 ;i < list.length;i++){
          if(i%2 != 0)
          list[i+1] = 100;
        }
        print(list);
      case "7":
        exit(0);
      default:
        print("Непонятная команда!");
    }
  }
}