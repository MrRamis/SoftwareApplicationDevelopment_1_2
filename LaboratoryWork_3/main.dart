import 'dart:io';
import 'dart:convert';

void main() async {

  await _gataGenerate();
  _worc2();
  var applicant = await _worc3();
  for (final person in applicant) {
    print(person);
  }
}

Future<void> _gataGenerate() async {
  File file = new File("applicants.json");
  if (!file.existsSync()){
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
      Applicant(
        new FullName("yuy", "naterteme", "patroertertnymic"),
        "2012, 5, 9",
        "2012, 11, 12",
        new GradesCertificate(2, 5),
        false,
        EntranceExamGrades(3, 5),
      ),
      Applicant(
        new FullName("y34253rtuy", "nertertame", "patronymic"),
        "2012, 5, 9",
        "2012, 11, 12",
        new GradesCertificate(3, 5),
        false,
        EntranceExamGrades(3, 2),
      ),
      Applicant(
        new FullName("yuy", "namehgiguhi", "patronymic"),
        "2012, 5, 9",
        "2012, 11, 12",
        new GradesCertificate(3, 2),
        false,
        EntranceExamGrades(3, 5),
      ),
    ];
    final encoded = json.encode(people);
    await File("applicants.json").writeAsString(encoded);
    print("Data Generate");
  }
}

Future<List<Applicant>> _getGateJson() async {
  return new Future(() async {
    final data = await File("applicants.json").readAsString();
    final decoded = json.decode(data);
    List<Applicant> applicant1 = [];
    for (final item in decoded) {
      final Applicant applicant = Applicant.fromJson(item);
      applicant1.add(applicant);
    }
    return applicant1;
  });
}

Future<void> _worc2() async {
  var applicant = await _getGateJson();
  applicant.removeWhere(
    (item) =>
        item.entranceExamGrades.russian < 3 &&
        item.entranceExamGrades.mathematics < 3 &&
        item.gradesCertificate.mathematics == 5 &&
        item.gradesCertificate.russian == 5,
  );
  final encoded = json.encode(applicant);
  await File("applicantsWork2.json").writeAsString(encoded);
  print("Data save work 2");
}

Future<List<Applicant>> _worc3() async {
  return new Future(() async {
    final data = await File("applicants.json").readAsString();
    final decoded = json.decode(data);
    List<Applicant> applicant1 = [];
    for (final item in decoded) {
      final Applicant applicant = Applicant.fromJson(item);
      applicant1.add(applicant);
    }
    final people = [
      Applicant(
        new FullName("yuyьту", "nameту", "patronymicапрар"),
        "2012, 1, 12",
        "2012, 1, 2",
        new GradesCertificate(5, 5),
        false,
        EntranceExamGrades(5, 5),
      ),
      Applicant(
        new FullName("рек", "вапв", "вап"),
        "2013, 1, 22",
        "2012, 10, 28",
        new GradesCertificate(5, 5),
        false,
        EntranceExamGrades(5, 5),
      ),
    ];
    applicant1.addAll(people);
    return applicant1
        .where(
          (item) =>
              item.gradesCertificate.mathematics == 5 &&
              item.gradesCertificate.russian == 5,
        )
        .toList();
  });
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
