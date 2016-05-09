﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    public class AnimalHandler
    {
        public AnimalHandler()
        {
        }

        public string getAnimal(string IdAnimal)
        {
            string response = "";

            string query = @"
				SELECT 
				  a.IdAnimal,
				  a.Name, 
				  h.Name HabitatName,
				  ht.Name HabitatType,
				  s.CommonName,
				  s.ScientificName
				FROM Animal a
				INNER JOIN Species s ON a.IdSpecies = s.IdSpecies
				INNER JOIN Habitat h ON h.IdHabitat = a.IdHabitat
				INNER JOIN HabitatType ht on ht.IdType = h.IdType
				WHERE a.IdAnimal = 
				" + IdAnimal;

            const string connectionString = "URI=file:/Users/stevebrownlee/dev/github/chortlehoort/SimpleServer/SimpleServer/Zoolandia.db";

            System.Data.IDbConnection dbcon = new SqliteConnection(connectionString);

            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcon.CreateCommand();

            dbcmd.CommandText = query;
            IDataReader reader = dbcmd.ExecuteReader();

            // Read advances to the next row.
            while (reader.Read())
            {
                response += "<div class=\"animal animal-id-" + reader[0] + "\">";
                response += "<h2>" + reader[1] + "</h2>";
                response += "<div>" + reader[5] + "</div>";
                response += "<div>Lives in the " + reader[2] + " (" + reader[3] + " type) habitat</div>";
                response += "</div>";
            }
            Console.WriteLine(response);

            // clean up
            reader.Dispose();
            dbcmd.Dispose();
            dbcon.Close();

            return response;
        }


        public string getAllAnimals()
        {
            string response = "";

            const string query = @"
				SELECT 
				  a.IdAnimal,
				  a.Name, 
				  h.Name HabitatName,
				  ht.Name HabitatType,
				  s.CommonName,
				  s.ScientificName
				FROM Animal a
				INNER JOIN Species s ON a.IdSpecies = s.IdSpecies
				INNER JOIN Habitat h ON h.IdHabitat = a.IdHabitat
				INNER JOIN HabitatType ht on ht.IdType = h.IdType
				";

            const string connectionString = "URI=file:/Users/stevebrownlee/dev/github/chortlehoort/SimpleServer/SimpleServer/Zoolandia.db";

            System.Data.IDbConnection dbcon = new SqliteConnection(connectionString);

            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcon.CreateCommand();

            dbcmd.CommandText = query;
            IDataReader reader = dbcmd.ExecuteReader();

            // Read advances to the next row.
            while (reader.Read())
            {
                response += "<div class=\"animal animal-id-" + reader[0] + "\">";
                response += "<h2>" + reader[1] + "</h2>";
                response += "<div><a href='/animals/" + reader[0] + "'>" + reader[5] + "</a></div>";
                response += "<div>Lives in the " + reader[2] + " (" + reader[3] + " type) habitat</div>";
                response += "</div>";
            }
            Console.WriteLine(response);

            // clean up
            reader.Dispose();
            dbcmd.Dispose();
            dbcon.Close();

            return response;
        }
    }
}
