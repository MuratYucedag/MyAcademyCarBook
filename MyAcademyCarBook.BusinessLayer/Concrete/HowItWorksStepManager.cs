using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class HowItWorksStepManager : IHowItWorksStepService
    {
        private readonly IHowItWorksStepDal _howItWorksStepDal;
        public HowItWorksStepManager(IHowItWorksStepDal howItWorksStepDal)
        {
            _howItWorksStepDal = howItWorksStepDal;
        }
        public void TDelete(HowItWorksStep entity)
        {
            _howItWorksStepDal.Delete(entity);
        }

        public HowItWorksStep TGetByID(int id)
        {
            return _howItWorksStepDal.GetByID(id);
        }

        public List<HowItWorksStep> TGetListAll()
        {
           return _howItWorksStepDal.GetListAll();
        }

        public void TInsert(HowItWorksStep entity)
        {
            _howItWorksStepDal.Insert(entity);
        }

        public void TUpdate(HowItWorksStep entity)
        {
           _howItWorksStepDal.Update(entity);
        }
    }
}
