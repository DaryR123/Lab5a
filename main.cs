using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Lab5a");

   int i; 
   
   double distance=0;
   double time=0;
   double speed=0;
   double average=0;
   double total=0;

   for(i = 1; i <= 7; i++)
   {
     Console.WriteLine("Enter the distance covered by cars #"+i);
     distance = Convert.ToDouble(Console.ReadLine());

     Console.WriteLine("Enter the time taken by car #" +1);
     time = Convert.ToDouble(Console.ReadLine());

     speed= distance/time;
     total+=speed;
     Console.WriteLine("The speed of the car is "+ speed +" miles per hour");
    
   }
   average =total/7;
   Console.WriteLine("The average speed of the cars is "+ average +"miles per hour");
  }
}






  