using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AppTestes.Models
{
    public class TesteXML
    {
        public static void Xml()
        {
            XNamespace ew = "ContactList";
            XElement root = new XElement(ew + "Root");
            Console.WriteLine(root);

            // Coreto
           
            XElement contactss = new XElement ("contacts",
            from c in Contacts.GetContacts()
            orderby c.ContactId
            select new XElement("contact",
            new XAttribute("contactId", c.ContactId),
            new XElement("firstName", c.FirstName),
            new XElement("lastName", c.LastName))
            );
            
            //  Errado
            XAttribute contacts = new XAttribute("contacts",
                from c in Contacts.GetContacts()
                orderby c.ContactId
                select new XElement("contact",
                new XAttribute("contactId", c.ContactId),
                new XElement("firstName", c.FirstName),
                new XElement("lastName", c.LastName))
                );
        }
    }

    public class Contacts
    {
        public int ContactId;
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static List<Contacts> GetContacts()
        {
            var lista = new List<Contacts>();

            for(int i = 0; i < 10; ++i)
            {
                lista.Add(new Contacts { ContactId = i, FirstName = $"Teste {i}", LastName = $"Teste {i + 1}" });
            }
            return lista;
        }
    }
}
