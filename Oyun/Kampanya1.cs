using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class Kampanya1 : IKampanyaManager
    {
              
        public void Add(Game game)
        {
            game.Price=Kampanya(game);
            Console.WriteLine(" kampanya-1 eklendi. "  );
        }

        public void Delete(Game game)
        {
            Console.WriteLine(" kampanya-1 silindi. Oyunun fiyatı: " +game.Price);
        }

        public int Kampanya(Game game)
        {
            int price = new Random().Next(100, 150);
            Console.Write("Kampanya 1: 'Yeni üyelere özel indirim' ");
            Console.WriteLine(" Kampanyaya özel yeni fiyatı: " + price);
            return price;
        }

        public int KampanyaNo(Game game)
        {
            return 1;
        }

        public int Update(Game game)
        {
            int price = new Random().Next(50, 100);
            Console.WriteLine(" kampanya-1 güncellendi. Oyunun yeni fiyat: " +price);
            return price;
        }

        
    }
}
