using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
   public interface IPetRepository
    {
        public List<PetObject> GetPetList();
        public PetObject GetPetByPetID(int id);
        public void InsertPet(PetObject pet);
        public void UpdatePet(PetObject pet);
        public void RemovePet(int id);
        public List<string> CheckQuantity(List<PetObject> cart);
        public void SubQuantityProduct(List<PetObject> cart);
        public void SetStatusPet();
    }
}
