using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    interface IKampanyaManager
    {
        int Kampanya(Game game);
        int KampanyaNo(Game game);
        void Add(Game game);
        int Update(Game game);
        void Delete(Game game);

    }
}
