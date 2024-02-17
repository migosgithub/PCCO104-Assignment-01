using System;

class Program {
  public static void Main (string[] args) 
  {
    decimal cent = 0.01m;
    decimal nickel = 0.05m;
    decimal quarter = 0.25m;
    decimal peso = 1;
    decimal lima = 5;
    decimal sampu = 10;
    decimal bente = 20;
    decimal fifty = 50;
    decimal onehund = 100;
    decimal twohund = 200;
    decimal fivehund = 500;
    decimal onethou = 1000;

    Console.WriteLine("Enter the denomination:");
    decimal money = Decimal.Parse(Console.ReadLine());

    if (money == cent)
    {
      Console.WriteLine($"No person is found in PHP {cent}");
    }
    else if (money == nickel)
    {
      Console.WriteLine($"No person is found in PHP {nickel}");
    }
    else if (money == quarter)
    {
      Console.WriteLine($"No person if found in PHP {quarter}");
    }
    else if (money == peso)
    {
      Console.WriteLine($"Jose Rizal is found in PHP {peso}");
    }
    else if (money == lima)
    {
      Console.WriteLine($"Emilio Aguinaldo is found in PHP {lima}");
    }
    else if (money == sampu)
    {
      Console.WriteLine($"Andres Bonifacio & Apolinario Mabini is found in PHP {sampu}");
    }
    else if (money == bente)
    {
      Console.WriteLine($"Manuel Quezon is found in PHP {bente}");
    }
    else if (money == fifty)
    {
      Console.WriteLine($"Sergio Osmena is found in PHP {fifty}");
    }
    else if (money == onehund)
    {
      Console.WriteLine($"Manuel Roxas is found in PHP {onehund}");
    }
    else if (money == twohund)
    {
      Console.WriteLine($"Diosdado Macapagal is found in PHP {twohund}");
    }
    else if (money == fivehund)
    {
      Console.WriteLine($"Benigno Aquino & Corazon Aquino is found in PHP {fivehund}");
    }
    else if (money == onethou)
    {
      Console.WriteLine($"Jose Abad Santos, Josefa Escoda, & Vicente Lim is found in PHP {onethou}");
    }
    else
    {
      Console.WriteLine($"Invalid Denomination: {money}");
    }
  }
}