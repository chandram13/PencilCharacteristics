// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;
    
// Constructors with Parameters

class Pencils
{
    public string brand;
    private int mm;
    private string store;
    private int num;
    private int priceOf;
}

public Pencils(string brandType, int mmType, string storeBought, int numPencils, int price)
{
    string brand = brandType;
    int mm = mmType;
    string store = storeBought;
    int num = numPencils;
    int priceOf = price;
};

public static void Main(string[] args)
{
    Pencils Lead = new Pencils("Bic");
    Console.WriteLine(Lead.brand);
    Pencils Lead = new Pencils(0.7);
    Console.WriteLine(Lead.mm);
    Pencils Lead = new Pencils("Walmart");
    Console.WriteLine(Lead.store);
    Pencils Lead = new Pencils(20);
    Console.WriteLine(Lead.num);
    Pencils Lead = new Pencils(8.99);
    Console.WriteLine(Lead.priceOf);
}
// Outputs the pencil's details that were defined in the last function based on the given inputs