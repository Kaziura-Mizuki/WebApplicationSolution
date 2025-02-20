namespace WebApplication2.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class TodoViewModel
    {
        public int user_id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
