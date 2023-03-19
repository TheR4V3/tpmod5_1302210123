// See https://aka.ms/new-console-template for more information
using System;

class HaloGeneric
{
    public void GreetUser<T>(T user)
    {
        Console.WriteLine($"Hello user {user}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string user = "Muhammad Rafa Eka Pramoedya";
        halo.GreetUser(user);
    }
}