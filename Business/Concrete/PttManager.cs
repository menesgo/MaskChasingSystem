using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplyerServices
    {
        private IApplicantServices _applicantServices; //field

        public PttManager(IApplicantServices applicantServices) //Constructor new yapıldığında çalışır
        {
            _applicantServices = applicantServices;
        }
        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
