﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoProje
{
    class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source=DESKTOP-61BLH0I;Initial Catalog=Northwind;Integrated Security=True"; //bağlantı yolunu Tools'ta verdik
            }
        }
    }
}
