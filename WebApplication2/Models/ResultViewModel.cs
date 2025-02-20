namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;

    public class ResultViewModel
    {
        public List<Result> resultList = new List<Result>();

        public string[] firstNameList = new string[] { "John", "Jane", "Jack" };
        public string[] familyNameList = new string[] { "Doe", "Smith", "Brown" };

        public partial class Result
        {
            public string FirstName { get; set; }
            public string FamilyName { get; set; }
        }
    }
}
