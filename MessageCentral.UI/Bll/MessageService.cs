using System;
using System.Collections.Generic;
using System.Linq;
using MessageCentral.UI.Data;

namespace MessageCentral.UI.Bll
{
    public class MessageService
    {
        public MessageService()
        {
        }

        public List<Tenant> GetTenantsByCriteria(string lastNameCriteria, string propertyAddress)
        {
            List<Tenant> tenants = new List<Tenant>();
            List<char> lastNameInitials = new List<char>();

            string[] lastNameCriteriaArray = lastNameCriteria.Split(',');

            foreach(string part in lastNameCriteriaArray)
            {
                if (part.Contains("-"))
                {
                    lastNameInitials.AddRange(GetCharactersFromRange(part));
                }
                else if (!lastNameInitials.Contains(char.Parse(part)))
                {
                    lastNameInitials.Add((char.Parse(part)));
                }
            }

            return TenantData.GetTenantList().Where(t => lastNameInitials.Contains(char.Parse(t.LastName.Substring(0, 1)))).ToList<Tenant>();

            // return tenants;
        }

        private List<char> GetCharactersFromRange(string range)
        {
            char[] alphabetArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();

            List<char> charList = new List<char>();

            int startPos = Array.IndexOf(alphabetArray,char.Parse(range.Substring(0, 1)));
            int endPos = Array.IndexOf(alphabetArray, char.Parse(range.Substring(2, 1)));

            for (int i = startPos; i <= endPos; i++)
            {
                if (!charList.Contains(alphabetArray[i]))
                {
                    charList.Add(alphabetArray[i]);
                }
            }

            return charList;

        }
         
    }
}
