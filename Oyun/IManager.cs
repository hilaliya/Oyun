namespace Oyun
{
     interface IManager
    {
        void Add(Oyuncu oyuncu, Game game);
        void Update(Oyuncu oyuncu, Game game);
        void Delete(Oyuncu oyuncu, Game game);
        
    }
}