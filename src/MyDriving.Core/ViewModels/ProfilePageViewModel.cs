using GalaSoft.MvvmLight;
using MyDriving.Core.Models;
using MyDriving.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDriving.Core.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        private readonly IVehicleRepository _repository;

        public Vehicle CurrentVehicle { get; set; }

        public ProfilePageViewModel(IVehicleRepository repository)
        {
            _repository = repository;
            Initialize();
        }

        private void Initialize()
        {
            CurrentVehicle = _repository.GetById(1);
        }
    }
}
