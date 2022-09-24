using LabTP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Logic
{
   public interface ILogic<T>
    {
        List<T> GetAll();
    }
}
