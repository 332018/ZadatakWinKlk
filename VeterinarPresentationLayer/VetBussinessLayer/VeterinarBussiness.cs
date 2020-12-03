using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetDataAccessLayer;
using VetDataAccessLayer.Models;

namespace VetBussinessLayer
{
    public class VeterinarBussiness
    {
        private readonly VeterinarRepository veterinarRepository;

        public VeterinarBussiness()
        {
            this.veterinarRepository = new VeterinarRepository();
        }

        public List<Veterinar> GetallVeterinars()
        {
            return this.veterinarRepository.GetAllVeterinars();
        }

        public bool InsertVeterinar(Veterinar v)
        {
            if(this.veterinarRepository.InsertVeterinar(v) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Veterinar> GetVeterinars(int god)
        {
            return this.veterinarRepository.GetAllVeterinars().Where(v => v.Years < god).ToList();
        }
    }
}
