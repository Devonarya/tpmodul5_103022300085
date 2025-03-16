// See https://aka.ms/new-console-template for more information
using System;

public class DataGeneric<T> { 
    public T Data { get; set;}

    public DataGeneric (T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tesimpan adalah: {Data}");
    }
}

class Program {
    static void Main() {
        DataGeneric<long> dataNIM = new DataGeneric<long>(103022300085);

        dataNIM.PrintData();
    }
}