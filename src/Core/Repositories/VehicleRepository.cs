using Microsoft.EntityFrameworkCore;
using MyDriving.Core.Data;
using MyDriving.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDriving.Core.Repositories
{
    class VehicleRepository : RepositoryBase, IRepository<Vehicle>
    {
        public Vehicle Get(int id)
        {
            return AppDbContext.Instance.Vehicles
                .Include(v => v.Fuellings)
                .FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Vehicle> GetAll(Func<Vehicle,bool> predicate = null)
        {
            if (predicate == null)
                return AppDbContext.Instance.Vehicles.ToList();

            return AppDbContext.Instance.Vehicles.Where(predicate);
        }

        public void Add(Vehicle entity)
        {
            AppDbContext.Instance.Vehicles.Add(entity);
            SaveAll();
        }

        public void Update(Vehicle entity)
        {
            AppDbContext.Instance.Vehicles.Update(entity);
            SaveAll();
        }

        public void Delete(Vehicle entity)
        {
            AppDbContext.Instance.Vehicles.Remove(entity);
            SaveAll();
        }
    }
}