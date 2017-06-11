﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //CREATES
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //READS
        TEntity Get(int? Id);
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //UPDATES
        //void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);

        //DELETES
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
