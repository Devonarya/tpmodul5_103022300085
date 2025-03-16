// See https://aka.ms/new-console-template for more information
using System;

public class HaloGeneric
{
    public static void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}
public class DataGeneric<T> {
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tesimpan adalah: {Data}");
    }
}

class Program {
    static void Main() 
    {
        HaloGeneric.SapaUser("Devon");

        DataGeneric<long> dataNIM = new DataGeneric<long>(103022300085);

        dataNIM.PrintData();
    }
 

}
