using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface ICampainService
    {
        void Add(Campain campain);
        void Update(Campain campain);
        void Remove(Campain campain);
    }
}
