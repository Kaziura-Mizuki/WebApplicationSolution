namespace WebApplication2.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    public partial class Todo
    {
        [Key]
        public int user_id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
