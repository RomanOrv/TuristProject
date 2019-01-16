using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using Turist.Entities;
using Turist.Repository.Interfaces;

namespace Turist.Repository
{
    public class TuristRepository : ITuristRepository
    {
        private readonly string _connectionString;
        public TuristRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IList<Informative> GetInformativeList()
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                return context.CreateObjectSet<Informative>().ToList();
            }
        }

        public IList<Safety> GetSafetyList()
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                return context.CreateObjectSet<Safety>().ToList();
            }
        }

        public IList<StaffQualification> GetStaffQualificationList()
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                return context.CreateObjectSet<StaffQualification>().ToList();
            }
        }

        public IList<Сomfort> GetСomfortList()
        {
            using (ObjectContext context = new ObjectContext(_connectionString))
            {
                return context.CreateObjectSet<Сomfort>().ToList();
            }
        }
    }
}
