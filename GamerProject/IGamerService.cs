﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Uptade(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
