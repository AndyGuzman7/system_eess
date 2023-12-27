using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Core
{
    public interface IUseCase<Type, Params>
    {
        Task<Type> Call(Params @params);
    }
    public class NoParams
    {

    }
}
