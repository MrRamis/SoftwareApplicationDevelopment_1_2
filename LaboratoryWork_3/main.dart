import 'dart:io';
import 'dart:convert';

void main() async {
  List<Person> tom = [Person("Tom", 38),Person("Tofggm", 534),Person("Tomgfhf", 43),Person("Tgom", 39)];
  var encoded = json.encode(tom);   // преобразуем в json
  File file = File("person.json");
  await file.writeAsString(encoded);    // запись в файл
  print("File has been written");

  final data = await File("people.json").readAsString();
  final decoded = json.decode(data);
  var people = [];
  // перебираем словарь списков и создаем по каждому словарю объект Peron
  for(final item in decoded){
    final Person person = Person.fromJson(item);  // создаем объект Person
    people.add(person);
  }
  // перебираем объекты Person для вывода на консоль
  for(final person in people){
    print(person);
  }
}
class Person{
  String name;
  int age;
  Person(this.name, this.age);

  factory Person.fromJson(Map<String, Object?> jsonMap){
    return Person(jsonMap["name"] as String, jsonMap["age"] as int);
  }

  Map toJson() => { "name": name, "age": age};
  @override
  toString() => "Name: $name \t Age: $age";
}