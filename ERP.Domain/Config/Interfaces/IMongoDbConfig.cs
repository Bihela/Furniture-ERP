using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Config.Interfaces
{
    internal interface IMongoDbConfig
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
