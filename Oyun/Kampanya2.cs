using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class Kampanya2 : IKampanyaManager
    {
        public void Add(Game game)
        {
            game.Price = Kampanya(game);
            Console.WriteLine(" kampanya-2 eklendi. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(" kampanya-2 silindi. Oyunun fiyatı: " + game.Price);
        }

        public int Kampanya(Game game)
        {
            int price = new Random().Next(20, 80);
            Console.Write("Kampanya 2: 'Yeni kampanya'  ");
            Console.WriteLine(" Kampyanyaya özel yeni fiyat: " + price);
            return price;
        }

        public int KampanyaNo(Game game)
        {
            return 2;
        }

        public int Update(Game game)
        {
            int price = new Random().Next(10, 100);
            Console.WriteLine(" kampanya-2 güncellendi. Yeni fiyat: " + price);          
            return price;
        }
    }
}
