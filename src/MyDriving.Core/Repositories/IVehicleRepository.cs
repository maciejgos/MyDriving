using MyDriving.Core.Models;

namespace MyDriving.Core.Repositories
{
    public interface IVehicleRepository
    {
        Vehicle GetById(int v);
    }
}