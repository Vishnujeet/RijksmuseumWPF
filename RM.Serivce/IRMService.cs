using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM.Common;

namespace RM.Service
{
    public interface IRMService
    {
        Task<Root> GetAllArtObject();
        Task<SingleArt> GetArtObjectDetails(string id);
    }
}
