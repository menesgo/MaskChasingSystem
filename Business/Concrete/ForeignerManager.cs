using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantServices
    {
        //Sonar Qube
        void IApplicantServices.ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        bool IApplicantServices.CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        List<Person> IApplicantServices.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
