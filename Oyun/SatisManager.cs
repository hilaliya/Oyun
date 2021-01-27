using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class SatisManager : IManager
    {        
        public void Delete(Oyuncu oyuncu, Game game)
        {
            Console.WriteLine("Oyun satışı iptal edilmiştir");
        }

        public void Add(Oyuncu oyuncu, Game game)
        {
            game.Price = 150;
            Console.WriteLine("Oyunun fiyatı: " + game.Price + " TL");
            Console.Write("\nKampanyaları görmek için tıklayınız ");
            Console.ReadLine();
            KampanyaUygula(game, new List<IKampanyaManager> { new Kampanya1(), new Kampanya2() });
            Console.Write("\nSiparişi tamamlamak için tıklayınız ");
            Console.ReadLine();
            Console.Write("\nKredi Kart numaranızı giriniz: ");
            oyuncu.Kartno = Console.ReadLine();
            HesapBilgileriniGetir(oyuncu);
            if(oyuncu.Bakiye>=game.Price)
            {
                Console.WriteLine("Oyun satın alınmıştır");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye: " + oyuncu.Bakiye);
            }

        }

        public void Update(Oyuncu oyuncu, Game game)
        {
            throw new NotImplementedException();
        }
        public void KampanyaUygula(Game game,  List<IKampanyaManager> kampanyalar)
        {
            foreach (var kampanya in kampanyalar)
            {
                kampanya.Kampanya(game);                
            }
            Console.Write("\nUygulamak istediğiniz kampanyanın numarasını giriniz: ");
            Kampanya1 kampanya1 = new Kampanya1();
            Kampanya2 kampanya2 = new Kampanya2();
          
            int selected= Convert.ToInt32(Console.ReadLine());
            if (selected==kampanya1.KampanyaNo(game))
            {
                Console.WriteLine("\nSeçilen Kampanya: " + kampanya1.KampanyaNo(game));
                kampanya1.Add(game);
            }
            else if (selected == kampanya2.KampanyaNo(game))
            {
                Console.WriteLine("Seçilen Kampanya: " + kampanya2.KampanyaNo(game));
                kampanya2.Add(game);
            }
            else 
            {
                Console.WriteLine("Kampanya seçilmedi");
            }

        }

        public void HesapBilgileriniGetir(Oyuncu oyuncu)
        {
            oyuncu.Bakiye = new Random().Next(0, 150);
            Console.WriteLine("Bakiye: " + oyuncu.Bakiye, "tl");

        }
    }
}
