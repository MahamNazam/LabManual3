using System;
class Astronaut
{
    public string Name;
    public int Oxygen;
    public int Stamina;
    public bool IsConscious;
    public Astronaut(string n)
    {
        Name = n;
        Oxygen = 100;
        Stamina = 60;
        IsConscious = true;
    }
}
class Program
{
    static void Main()
    {
        Astronaut[] a = new Astronaut[4];
        a[0] = new Astronaut("Ali");
        a[1] = new Astronaut("Sara");
        a[2] = new Astronaut("Ahmed");
        a[3] = new Astronaut("Zara");
        Random r = new Random();
        Console.WriteLine("--- SPACE MISSION STARTED ---");
        for (int cycle = 1; cycle <= 10; cycle++)
        {
            Console.WriteLine("Cycle " + cycle);
            for (int i = 0; i < 4; i++)
            {
                if (a[i].IsConscious == false)
                    continue;
                int eventNo = r.Next(1, 6);
                if (eventNo == 1)
                {
                    a[i].Oxygen = a[i].Oxygen + 15;
                    if (a[i].Oxygen > 100) a[i].Oxygen = 100;
                    Console.WriteLine(a[i].Name + " refilled oxygen. Oxygen +15");
                }
                else if (eventNo == 2)
                {
                    a[i].Oxygen = a[i].Oxygen - 25;
                    Console.WriteLine(a[i].Name + " hit by meteor. Oxygen -25");
                }
                else if (eventNo == 3)
                {
                    a[i].Stamina = a[i].Stamina + 10;
                    Console.WriteLine(a[i].Name + " took break. Stamina +10");
                }
                else if (eventNo == 4)
                {
                    a[i].Stamina = a[i].Stamina - 15;
                    Console.WriteLine(a[i].Name + " equipment failure. Stamina -15");
                }
                else
                {
                    Console.WriteLine(a[i].Name + " smooth cycle. No change");
                }
                if (a[i].Oxygen <= 0)
                {
                    a[i].IsConscious = false;
                    a[i].Oxygen = 0;
                }
            }
        }
        Console.WriteLine("--- FINAL RESULTS ---");
        int max = 0;
        string winner = "";
        for (int i = 0; i < 4; i++)
        {
            string state = a[i].IsConscious ? "Conscious" : "Unconscious";
            Console.WriteLine(a[i].Name + " -> Oxygen: " + a[i].Oxygen + " Stamina: " + a[i].Stamina + " " + state);
            if (a[i].Oxygen > max)
            {
                max = a[i].Oxygen;
                winner = a[i].Name;
            }
        }
        Console.WriteLine("Winner: " + winner + " (Highest Oxygen)");
    }
}
