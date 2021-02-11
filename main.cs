using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celcius");
    double tempC = Convert.ToDouble(Console.ReadLine());
    double tempF = tempC*9/5+32;
    Console.WriteLine("Farenheit equivalent for "+tempC+" degree Celcius is "+ tempF);
    if (tempF<32){
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
    }
    else if (tempF>212)
      Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");

   

  }
}