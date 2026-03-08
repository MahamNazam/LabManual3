using System;
class Character
{
    public string Name;
    public int Health;
    public int Attack;
    public Character(string n, int h, int a)
    {
        Name = n;
        Health = h;
        Attack = a;
    }
    public Character(Character c)
    {
        Name = c.Name;
        Health = c.Health;
        Attack = c.Attack;
    }
}
class Program
{
    static void Main()
    {
        Character warrior = new Character("Warrior", 100, 20);
        Character ninja = new Character("Ninja", 90, 15);
        Console.WriteLine("--- BATTLE STARTED ---");
        ninja.Health = ninja.Health - warrior.Attack;
        Console.WriteLine("Warrior attacks Ninja -> Ninja Health: " + ninja.Health);
        warrior.Health = warrior.Health - ninja.Attack;
        Console.WriteLine("Ninja attacks Warrior -> Warrior Health: " + warrior.Health);
        Character clone = new Character(warrior);
        Console.WriteLine("Clone Warrior joins battle");
       int round = 3;
        while (ninja.Health > 0 && clone.Health > 0)
        {
            Console.WriteLine("Round " + round);
            ninja.Health = ninja.Health - clone.Attack;
            Console.WriteLine("Clone Warrior attacks Ninja -> Ninja Health: " + ninja.Health);
            if (ninja.Health <= 0)
            {
                Console.WriteLine("Ninja has been defeated!");
                Console.WriteLine("Winner: Warrior");
                break;
            }
            clone.Health = clone.Health - ninja.Attack;
            Console.WriteLine("Ninja attacks Clone Warrior -> Clone Health: " + clone.Health);
            round++;
        }
    }
}
