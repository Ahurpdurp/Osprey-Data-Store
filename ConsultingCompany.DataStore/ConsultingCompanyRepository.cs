
namespace ConsultingCompany.DataStore
{
    using System.Collections.Generic;
    using System;
    using ConsultingCompany.Lib;

    public class ConsultingCompanyRepository : IConsultingCompanyRepository
    {
        public ConsultingCompanyRepository()
        {
            Initialize();
        }

        private List<Resource> _resources = null;

        private List<Client> _clients = null;

        public List<Resource> Resources
        {
            get
            {
                return this._resources;
            }
        }


        public List<Client> Clients
        {
            get
            {
                return this._clients;
            }
        }

        private void Initialize()
        {
            this._resources = new List<Resource>()
                                  {
                                      new Resource() { FirstName = "Chris", LastName = "Smith", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Brian", LastName = "Jones", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Mary", LastName = "Bill", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Lin", LastName = "Mayer", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Jason", LastName = "Gold", Type = ResourceType.ProjectManager },
                                      new Resource() { FirstName = "Jennifer", LastName = "Mike", Type = ResourceType.ProjectManager },
                                      new Resource() { FirstName = "Bob", LastName = "Lawrence", Type = ResourceType.Architect },
                                      new Resource() { FirstName = "Susan", LastName = "Kennedy", Type = ResourceType.QA },
                                      new Resource() { FirstName = "Jerry", LastName = "Williams", Type = ResourceType.Architect },
                                      new Resource() { FirstName = "Eric", LastName = "Hammill", Type = ResourceType.QA }
                                  };

            this._clients = new List<Client>()
                                {
                                    new Client()
                                        {
                                            ClientId = 1,
                                            CompanyName = "Microsoft",
                                            ContactFirstName = "Bill",
                                            ContactLastName = "Gates",
                                            City = "Redmond",
                                            State = "WA",
                                            Zip = "98052",
                                            LastUpdated = "6/18/2019 12:00:00 AM"
                                        },
                                    new Client()
                                        {
                                            ClientId = 2,
                                            CompanyName = "Facebook",
                                            ContactFirstName = "Mark",
                                            ContactLastName = "Zuckerberg",
                                            City = "Menlo Park",
                                            State = "CA",
                                            Zip = "94025",
                                            LastUpdated = "6/18/2019 12:00:00 AM"
                                        },
                                    new Client()
                                        {
                                            ClientId = 3,
                                            CompanyName = "Amazon", ContactFirstName = "Jeff", ContactLastName = "Bezos",
                                            City = "Seattle",
                                            State = "WA",
                                            Zip = "98108",
                                            LastUpdated = "6/18/2019 12:00:00 AM"},
                                };
        }
    }
}
