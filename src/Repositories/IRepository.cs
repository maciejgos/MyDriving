﻿using System;
using System.Collections.Generic;
using MyDriving.Models;

namespace MyDriving.Repositories
{
    interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        Vehicle Get(int id);
        IEnumerable<T> GetAll(Func<T, bool> predicate);
        void Update(T entity);
    }
}