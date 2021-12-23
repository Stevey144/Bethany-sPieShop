using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Module
{
    public interface IPieRepository
    {
        IEnumerable <Pie> Allpies { get; }
        IEnumerable <Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
