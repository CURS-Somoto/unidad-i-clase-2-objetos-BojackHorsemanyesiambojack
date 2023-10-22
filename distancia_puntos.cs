
using System;


internal class Program{

static void Main ()
{

Console.WriteLine("==================================================");
Console.WriteLine("DATO1:Ingrese el dato X, presione enter y luego ingrese el dato Y, luego introduzca el dato Z");
Console.WriteLine("==================================================");


    Punto UserData = new Punto (double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));

Console.WriteLine ($"Dato ingresado = ({UserData.x},{UserData.y},{UserData.z})");
Console.WriteLine ("///////////////////////////////////////////////");

Console.WriteLine("==================================================");
Console.WriteLine("DATO2:Ingrese el dato X, presione enter y luego ingrese el dato Y luego introduzca el dato Z");
Console.WriteLine("==================================================");


Punto UserData_2 = new Punto (double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
Console.WriteLine ($"Dato ingresado = ({UserData_2.x},{UserData_2.y},{UserData_2.z})");
Console.WriteLine ("///////////////////////////////////////////////");


UserData.Calcule_Distance(UserData_2);



Console.WriteLine("\n");
Console.WriteLine ("===============================================");
Console.WriteLine($"La distancia obtenida en la presente ecuacion es {(Punto.Distance.ToString("C2").Replace ("€",""))}");
Console.WriteLine ("===============================================");

}



public class Punto{


public static double Distance {get; set;}


public double x {get; set;}

public double y {get; set;}

public double z {get; set;}


public Punto (double CordX, double CordY,double CordZ)
{
x=CordX;
y=CordY;
z=CordZ;

}

public double Calcule_Distance(Punto Point_Destiny){

Distance =  Math.Sqrt(Math.Pow(x-Point_Destiny.x,2) + Math.Pow( y-Point_Destiny.y,2)+ Math.Pow(z-Point_Destiny.z,2));



return Distance;
}


}


}
