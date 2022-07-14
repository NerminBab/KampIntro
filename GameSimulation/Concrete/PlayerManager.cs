using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
   
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player)==true)
            {
                Console.WriteLine("Yeni oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama yapılamadı, kayıt başarısız.");
            }
        }

        ICampainService _campainService;
        public PlayerManager(ICampainService campainService)
        {
            _campainService = campainService;
        }

        public void Count(Player player)
        {
            Console.WriteLine("Oynayan toplam oyuncu sayısı: ");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
