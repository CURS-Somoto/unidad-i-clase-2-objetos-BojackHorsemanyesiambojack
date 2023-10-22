using System.ComponentModel.Design;

using System.Threading;


public class program {





    public static void Main (){

        Console.WriteLine("====================================");
        Console.WriteLine ("Presiona cualquier tecla para jugar");
        Console.WriteLine("====================================");

        Console.ReadKey();
        Guerrero Scorpion = new Guerrero ("Scorpion",100);
        Guerrero SubZero = new Guerrero ("Sub Zero",100);
        Battle Batalla = new Battle (Scorpion, SubZero);
        Batalla.iniciar();

        Console.WriteLine($"El ganador  de la batalla es {Battle.Winner}");

    }

   public class Guerrero {

    public bool damaged = false;
    public string name  {get; set;}
    public int HP  {get; set;}

    public int Damage {get; set;}

public Guerrero (string n, int H){
name = n;
HP = H;



}

public string Elegir (){

string [] options = new[]  { "Golpe", "Patada", "Ataque especial" };
Random x = new Random();
return options [x.Next(0, 3)];

}

public void ataque (Guerrero another){
another.HP = another.HP-Damage;

}
public void recibir (Guerrero another){
   HP=HP-another.Damage;



    
}
    }

public  class Battle{




public static string Winner {get; set;}

public Guerrero Guerrero1{get; set;}

public Guerrero Guerrero2 {get; set;}

public Battle (Guerrero p1, Guerrero p2){

    Guerrero1=p1;
    Guerrero2=p2;
}

public string iniciar(){





while (Guerrero1.HP >0 && Guerrero2.HP >0){

string part1 = Guerrero1.Elegir();

string part2 = Guerrero2.Elegir();




//Guerrero 1===============================================================================================================

    if (part1=="Golpe"){
        if (Guerrero1.HP>0){
        Guerrero1.Damage=10;
        Guerrero1.ataque(Guerrero2);
        Console.WriteLine($"{Guerrero1.name} Lanza {part1}");
        Console.WriteLine($"{Guerrero2.name} Recibe {part1} y pierde {Guerrero1.Damage} puntos de vida ");
        
        
        System.Threading.Thread.Sleep(500);
        
        }
    }
    if (part1=="Patada"){
        if (Guerrero1.HP>0){
        Guerrero1.Damage=20;
        Guerrero1.ataque(Guerrero2);
        Console.WriteLine($"{Guerrero1.name} Lanza {part1}");
        Console.WriteLine($"{Guerrero2.name} Recibe {part1} y pierde {Guerrero1.Damage} puntos de vida ");
        
        
                System.Threading.Thread.Sleep(500);
        
        }
    }
    if (part1=="Ataque especial"){
                if (Guerrero1.HP>0){
        Guerrero1.Damage=30;
        Guerrero1.ataque(Guerrero2);
        Console.WriteLine($"{Guerrero1.name} Lanza {part1}");
        Console.WriteLine($"{Guerrero2.name} Recibe {part1} y pierde {Guerrero1.Damage} puntos de vida ");
        
        
                System.Threading.Thread.Sleep(500);
                }
    }




    //Guerrero 2=========================================================================================================

    if (part2=="Golpe"){
                if (Guerrero2.HP>0){
        Guerrero2.Damage=10;
        Guerrero2.ataque(Guerrero1);
        Console.WriteLine($"{Guerrero2.name} Lanza {part2}");
        Console.WriteLine($"{Guerrero1.name} Recibe {part2} y pierde {Guerrero2.Damage} puntos de vida ");
        
        
        System.Threading.Thread.Sleep(500);
                }
    }
    if (part2=="Patada"){
         if (Guerrero2.HP>0){
        Guerrero2.Damage=20;
        Guerrero2.ataque(Guerrero1);

        Console.WriteLine($"{Guerrero2.name} Lanza {part2}");
        Console.WriteLine($"{Guerrero1.name} Recibe {part2} y pierde {Guerrero2.Damage} puntos de vida ");
        
        
                System.Threading.Thread.Sleep(500);
         }
        
    }
    if (part2=="Ataque especial"){
        if (Guerrero2.HP>0){
        Guerrero2.Damage=30;
        Guerrero2.ataque(Guerrero1);

        Console.WriteLine($"{Guerrero2.name} Lanza {part2}");
        Console.WriteLine($"{Guerrero1.name} Recibe {part2} y pierde {Guerrero2.Damage} puntos de vida ");
        
        
                System.Threading.Thread.Sleep(500);
        }
    }
}



if (Guerrero1.HP<=0){
    Winner=$"{Guerrero2.name}";
}
if (Guerrero2.HP<=0){
    Winner=$"{Guerrero1.name}";
}
return Winner;
}

}
    


}

