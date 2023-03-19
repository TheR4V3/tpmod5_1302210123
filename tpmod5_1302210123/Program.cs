// See https://aka.ms/new-console-template for more information
using System;

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data stored is: {data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nim = "1302210123";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}