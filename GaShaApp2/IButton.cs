using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaShaApp2
{
 
    public interface IInsertCoins
    {
        event Action<object, EventArgs> InsertedCoins;
    }
    public interface IReturnCoins
    {

    }
    public interface IDeliverItems
    {

    }
}
