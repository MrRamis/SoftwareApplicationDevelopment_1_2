import 'geographical_feature.dart';

class Sea extends GeographicalFeature{
  double square;
  String ocean;
  Sea(super.name, this.square, this.ocean);
  @override
  void toStringThis() {
    print(this);
  }
}