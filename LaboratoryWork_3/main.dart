import 'dart:io';
import 'dart:convert';

void main() async {
  final people = [
    Applicant(
      new FullName("yuy", "name", "patronymic"),
      "2012, 1, 12",
      "2012, 1, 2",
      new GradesCertificate(4, 5),
      false,
      EntranceExamGrades(3, 5),
    ),
    Applicant(
      new FullName("ytyruy", "name", "patronymic"),
      "2012, 1, 22",
      "2012, 10, 28",
      new GradesCertificate(5, 5),
      false,
      EntranceExamGrades(2, 5),
    ),
    Applicant(
      new FullName("yuy", "name", "patronymic"),
      "2012, 5, 9",
      "2012, 11, 12",
      new GradesCertificate(3, 5),
      false,
      EntranceExamGrades(3, 5),
    ),
  ];
  final encoded = json.encode(people,);
  await File("applicant.json").writeAsString(encoded);
  print("Data saved");

  final data = await File("applicant.json").readAsString();
  final decoded = json.decode(data);
  var applicant1 = [];
  for (final item in decoded) {
    final Applicant applicant = Applicant.fromJson(item);
    applicant1.add(applicant);
  }
  for (final person in applicant1) {
    print(person);
  }
}

class Applicant {
  FullName fullName;
  String yearBirth;
  String yearGraduation;
  GradesCertificate gradesCertificate;
  bool dormitory;
  EntranceExamGrades entranceExamGrades;

  Applicant(
    this.fullName,
    this.yearBirth,
    this.yearGraduation,
    this.gradesCertificate,
    this.dormitory,
    this.entranceExamGrades,
  );

  factory Applicant.fromJson(Map<String, Object?> jsonMap) {
    return Applicant(
      FullName.fromJson(jsonMap['fullName'] as Map<String, Object?>),
      jsonMap['yearBirth'] as String,
      jsonMap['yearGraduation'] as String,
      GradesCertificate.fromJson(
        jsonMap['gradesCertificate'] as Map<String, Object?>,
      ),
      jsonMap['dormitory'] as bool,
      EntranceExamGrades.fromJson(
        jsonMap['entranceExamGrades'] as Map<String, Object?>,
      ),
    );
  }

  Map toJson() => {
    "fullName": fullName,
    "yearBirth": yearBirth,
    "yearGraduation": yearGraduation,
    "gradesCertificate": gradesCertificate,
    "dormitory": dormitory,
    "entranceExamGrades": entranceExamGrades,
  };

  @override
  toString() => """FullName: $fullName\t
      yearBirth: $yearBirth\t
      yearGraduation: $yearGraduation\t
      gradesCertificate: $gradesCertificate\t
      dormitory: $dormitory\t
      entranceExamGrades: $entranceExamGrades""";
}

class FullName {
  String surname;
  String name;
  String patronymic;

  FullName(this.surname, this.name, this.patronymic);

  factory FullName.fromJson(Map<String, Object?> jsonMap) {
    return FullName(
      jsonMap["surname"] as String,
      jsonMap["name"] as String,
      jsonMap["patronymic"] as String,
    );
  }

  Map toJson() => {"surname": surname, "name": name, "patronymic": patronymic};

  @override
  toString() => "Surname: $surname \t Name: $name\t Patronymic: $patronymic";
}

class GradesCertificate {
  int mathematics;
  int russian;

  GradesCertificate(this.mathematics, this.russian);

  factory GradesCertificate.fromJson(Map<String, Object?> jsonMap) {
    return GradesCertificate(
      jsonMap["mathematics"] as int,
      jsonMap["russian"] as int,
    );
  }

  Map toJson() => {"mathematics": mathematics, "russian": russian};

  @override
  toString() => "mathematics: $mathematics \t russian: $russian";
}

class EntranceExamGrades {
  int mathematics;
  int russian;

  EntranceExamGrades(this.mathematics, this.russian);

  factory EntranceExamGrades.fromJson(Map<String, Object?> jsonMap) {
    return EntranceExamGrades(
      jsonMap["mathematics"] as int,
      jsonMap["russian"] as int,
    );
  }

  Map toJson() => {"mathematics": mathematics, "russian": russian};

  @override
  toString() => "mathematics: $mathematics \t russian: $russian";
}
