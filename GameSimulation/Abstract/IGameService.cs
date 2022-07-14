using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
