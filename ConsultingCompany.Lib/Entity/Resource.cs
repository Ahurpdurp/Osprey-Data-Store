using System;

namespace ConsultingCompany.Lib
{
    public enum ResourceType
    {
        ProjectManager,
        Architect,
        Developer,
        QA
    }

    public class Resource
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ResourceType Type { get; set; }
    }
}
