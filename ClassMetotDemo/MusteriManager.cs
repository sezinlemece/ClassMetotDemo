﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müsteri Ekle");
            Console.WriteLine("Müşteri TC no: " + musteri.Id);
            Console.WriteLine("Müşteri Adı Soyadı : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Ekle2(Musteri musteri)
        {

            Console.WriteLine("Müsteri Listele ");
            Console.WriteLine("Müşteri TC no: " + musteri.Id);
            Console.WriteLine("Müşteri Adı Soyadı : " + musteri.Adi + " " + musteri.Soyadi);

        }

        public void Ekle3(Musteri musteri)
        {

            Console.WriteLine("Müsteri Sil ");
            Console.WriteLine("Müşteri TC no: " + musteri.Id);
            Console.WriteLine("Müşteri Adı Soyadı : " + musteri.Adi + " " + musteri.Soyadi);

        }
    }
}


