using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

public class MatematikselIslemler
{

    // f(x,y) = x+y
    public void Topla(int sayi1,int sayi2)
    {
        Console.WriteLine(sayi1+sayi2);
    }
    public void Carp(int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1*sayi2);
    }

    public void Bol(int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1/sayi2);
    }


    public int Cikar(int sayi1, int sayi2)
    {
        // web arayüzü
        // mobil
        // console 
        return sayi1 - sayi2;
    }

}
