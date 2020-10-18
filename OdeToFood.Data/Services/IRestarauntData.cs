using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.Services
{
    public interface IRestarauntData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
