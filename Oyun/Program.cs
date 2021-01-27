using System;
using System.Collections.Generic;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Gamer!");

            Oyuncu oyuncu1 = new Oyuncu();
            {
                oyuncu1.Name = "Hilal";
                oyuncu1.Surname = "Yilmaz";
                oyuncu1.TC = 234567892;
                oyuncu1.Dogum = 1995;
                oyuncu1.Mail = "hilal@mail.com";
            }

            Oyuncu oyuncu2 = new Oyuncu();
            {
                oyuncu2.Name = "Bilal";
                oyuncu2.Surname = "Yilmaz";
                oyuncu2.Dogum = 1997;
                oyuncu2.Mail = "Bilal@mail.com";
            }

            OyuncuManager oyuncuManager = new OyuncuManager();
            SatisManager satisManager = new SatisManager();

            Game game = new Game();
           

   
            oyuncuManager.Add(oyuncu1,game);
            oyuncuManager.Update(oyuncu1,game);
            satisManager.Add(oyuncu1, game);
           // satisManager.KampanyaUygula(game, new List<IKampanyaManager> { new Kampanya1(), new Kampanya2() });
      

        }
    }
}
