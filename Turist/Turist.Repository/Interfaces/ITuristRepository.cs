using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turist.Entities;

namespace Turist.Repository.Interfaces
{
   public interface ITuristRepository
   {
       IList<Safety> GetSafetyList();
       IList<Сomfort> GetСomfortList();
       IList<Informative> GetInformativeList();
       IList<StaffQualification> GetStaffQualificationList();

    }
}
