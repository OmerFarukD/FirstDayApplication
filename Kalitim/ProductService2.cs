﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim;

public class ProductService2 : IProductService
{
    public void Add()
    {
        Console.WriteLine("2. Servise eklendi.");
    }

    public void GetList()
    {
        Console.WriteLine("2. Servisteki ürünler listelendi.");
    }

    public void Remove()
    {
        Console.WriteLine("2. Servisten silindi.");
    }
}
