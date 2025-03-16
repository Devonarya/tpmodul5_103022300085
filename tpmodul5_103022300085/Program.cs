// See https://aka.ms/new-console-template for more information
using System;

public class HaloGeneric
{
    public static void SapaUser<T>(T nama) 
    {
        Console.WriteLine($"Halo user {nama}");    
    }
}

class Program {
    static void Main() 
    {
        HaloGeneric.SapaUser("Devon");
    }
 

}

