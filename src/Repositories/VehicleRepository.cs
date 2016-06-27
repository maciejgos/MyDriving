using MyDriving.Data;
using MyDriving.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDriving.Repositories
{
    class VehicleRepository : RepositoryBase, IRepository<Vehicle>
    {
        public Vehicle Get(int id)
        {
            return AppDbContext.Instance.Vehicles.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Vehicle> GetAll(Func<Vehicle,bool> predicate)
        {
            return AppDbContext.Instance.Vehicles.Where(predicate);
        }

        public void Add(Vehicle entity)
        {
            AppDbContext.Instance.Vehicles.Add(entity);
        }

        public void Update(Vehicle entity)
        {
            AppDbContext.Instance.Vehicles.Update(entity);
        }

        public void Delete(Vehicle entity)
        {
            AppDbContext.Instance.Vehicles.Remove(entity);
        }
    }
}