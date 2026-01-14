using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace HiTechBooksManagement.DAL
{
    public class QuebecCitiesDB
    {
        private static readonly List<string> staticQuebecCities = new List<string>
        {
            "Montreal", "Quebec City", "Laval", "Gatineau", "Longueuil",
            "Sherbrooke", "Saguenay", "Levis", "Trois-Rivieres", "Terrebonne",
            "Saint-Jean-sur-Richelieu", "Repentigny", "Brossard", "Drummondville",
            "Saint-Jerome", "Granby", "Blainville", "Saint-Hyacinthe", "Mirabel",
            "Shawinigan", "Dollard-des-Ormeaux", "Rimouski", "Victoriaville",
            "Mascouche", "Chateauguay", "Saint-Eustache", "Boisbriand",
            "Salaberry-de-Valleyfield", "Sorel-Tracy", "Vaudreuil-Dorion"
        };

        public static List<string> GetAllQuebecCities()
        {
            return staticQuebecCities.OrderBy(c => c).ToList();
        }

        public static bool IsValidQuebecCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return false;

            bool isValid = staticQuebecCities.Contains(city.Trim(), StringComparer.OrdinalIgnoreCase);

            // If not found in static list, check database (optional)
            if (!isValid)
            {
                // You could add database check here if needed
            }

            return isValid;
        }

        public static DataTable GetQuebecCitiesForComboBox(bool includeEmptyOption = true)
        {
            DataTable dtCities = new DataTable();
            dtCities.Columns.Add("Display", typeof(string));
            dtCities.Columns.Add("Value", typeof(string));

            if (includeEmptyOption)
            {
                dtCities.Rows.Add("-- Select a City --", "");
            }

            foreach (var city in GetAllQuebecCities())
            {
                dtCities.Rows.Add(city, city);
            }

            return dtCities;
        }

        public static bool AddQuebecCity(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName) ||
                staticQuebecCities.Contains(cityName, StringComparer.OrdinalIgnoreCase))
            {
                return false;
            }

            staticQuebecCities.Add(cityName);
            return true;

        
        }
    }
}