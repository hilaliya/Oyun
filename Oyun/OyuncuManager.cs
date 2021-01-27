using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class OyuncuManager : IManager
    {
        
        public void Add(Oyuncu oyuncu,Game game)
        { 
               
            if (CheckIfRealPerson(oyuncu))  
            {
                Console.WriteLine(oyuncu.Name + " " + oyuncu.Surname + " kaydınız başarıyla yapılmıştır");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public bool CheckIfRealPerson(Oyuncu oyuncu)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //client.TCKimlikNoDogrulaAsync(oyuncu.TC, oyuncu.Name, oyuncu.Surname, oyuncu.Dogum);
            // return client.TCKimlikNoDogrulaAsync(oyuncu.TC, oyuncu.Name, oyuncu.Surname, oyuncu.Dogum);
            TCKimlikNoDogrulaRequestBody client = new TCKimlikNoDogrulaRequestBody();
            TCKimlikNoDogrulaRequest request = new TCKimlikNoDogrulaRequest();
            
            client.Ad = oyuncu.Name;
            client.Soyad = oyuncu.Surname;
            client.TCKimlikNo = oyuncu.TC;
            request.Body = client;
                              
            return true;
        }
        public void Update(Oyuncu oyuncu, Game game)
        {
            Console.Write("Bilgilerinizi güncellemek için tıklayınız: ");
            Console.ReadLine();
            Console.Write("Yeni mail adresiniz: ");
            oyuncu.Mail = Console.ReadLine();
            Console.WriteLine("profiliniz başarıyla güncellenmiştir");
        }    

        public void Delete(Oyuncu oyuncu, Game game)
        {
            Console.WriteLine("Hesabınız silinmiştir");
        }

            
    }
}

