using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.Data
{
    public class EvolveMigrations
    {
        public static void Migrate(string connectionString)
        {
            var evolveConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            // TODO: Third param -> Log action like 'msg => _logger.Log(msg)'
            // TODO: Check if its possible to keep 'evolve.json' and the folder 'Scripts' in the Data Project
            var evolve = new Evolve.Evolve("evolve.json", evolveConnection)
            {
                Locations = new List<string> { "Scripts/Migrations", "Scripts/Datasets" },
                IsEraseDisabled = true
            };

            evolve.Migrate();
        }
    }
}