using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDb.models;

namespace MVCDb.Models
{
    public interface IDept
    {
        public List<Dept> GetDepts();
        public Dept Find(int id);
        public void AddDept(Dept dept);
        public void EditDept(Dept dept);
        public void DeleteDept(Dept dept);
    }
}
