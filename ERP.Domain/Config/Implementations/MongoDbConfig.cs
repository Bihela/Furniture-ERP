using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Config.Interfaces;

namespace ERP.Domain.Config.Implementations
{
	internal class MongoDbConfig : IMongoDbConfig
	{
		public string DatabaseName { get; set; }
		public string ConnectionString { get; set; }
		public MongoDbConfig(string connectionString, string databaseName) 
		{
			DatabaseName = databaseName;
			connectionString = connectionString;
		}
	}
}
