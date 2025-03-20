class Receip
{
  late int _number;
  late DateTime _date;
  late double _sum;
  static int _count = 0;
  
  Receip(){
    this._number = 22;
    this._date = new DateTime(2000,07,09);
    this._sum = 4;
    _count++;
  }
  Receip.p(this._number,this._date,this._sum){
    _count++;
  }
  Receip.r(Receip receip ){
    this._number = _number;
    this._date = receip._date;
    this._sum = receip._sum;
    _count++;
  }



  void show() => print("Номер: $_number; дата: $_date; сумма: $_sum.");

  int getNumber() => _number;

  DateTime getDate() => _date;

  double getSum() => _sum;
  int getCount() => _count;
}
