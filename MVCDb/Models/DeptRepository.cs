﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCDb.models;


namespace MVCDb.Models
{
    public class DeptRepository : IDept
    {
        _1026dbContext context = new _1026dbContext();

        public void AddDept(Dept dept)
        {
            throw new NotImplementedException();
        }

        public void DeleteDept(Dept dept)
        {
            throw new NotImplementedException();
        }

        public void EditDept(Dept dept)
        {
            throw new NotImplementedException();
        }

        public Dept Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dept> GetDepts()
        {
            //var data = from dept in context.Depts select dept;
            //return data;
            return context.Depts.ToList();
        }
    }
}
