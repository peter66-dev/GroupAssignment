using Business_Object;
using DataAccess;
using System;
using System.Globalization;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var p in PetDAO.Instance.GetPetList())
            {
                Console.WriteLine(p.PetName);
            }

        }
    }
}
