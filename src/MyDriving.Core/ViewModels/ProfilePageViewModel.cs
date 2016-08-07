using GalaSoft.MvvmLight;
using MyDriving.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDriving.Core.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        public Vehicle CurrentVehicle { get; set; }
    }
}
