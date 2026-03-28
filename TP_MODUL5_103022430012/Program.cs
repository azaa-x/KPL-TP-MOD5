using System;

// Class pertama
class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

// Class kedua
class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama: ");
        string X = Console.ReadLine();

        Console.Write("Masukkan NIM: ");
        string Y = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(X);

        DataGeneric<string> data = new DataGeneric<string>(Y);
        data.PrintData();

        Console.ReadLine();
    }
}