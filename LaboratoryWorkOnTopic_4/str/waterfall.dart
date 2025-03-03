import 'geographical_feature.dart';

class Waterfall extends GeographicalFeature{
  double height;
  String country;
  Waterfall(super.name, this.height,this.country);

  @override
  void toStringThis() {
    print(this);
  }
}