﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Contracts
{
    //<T> Tipo de dado genérico
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T obj);
        void Update(T obj);
        void Remove(T obj);

        List<T> FindAll();
        T FindById(int id);
    }
}