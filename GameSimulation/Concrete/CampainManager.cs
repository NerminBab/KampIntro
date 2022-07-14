using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class CampainManager : ICampainService
    {
        public void Add(Campain campain)
        {
            Console.WriteLine("Sepette %50 kampanyası eklendi.");
        }

        public void Remove(Campain campain)
        {
            Console.WriteLine("Sepette %50 kampanyası kaldırıldı.");
        }

        public void Update(Campain campain)
        {
            Console.WriteLine("Sepette %50 kampanyası güncellendi.");
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }

        internal void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
