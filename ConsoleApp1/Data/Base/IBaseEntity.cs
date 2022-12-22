using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
