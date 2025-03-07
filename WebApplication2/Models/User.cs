namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class User
    {
        [Key]　//主キーの設定をしています
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //自動採番の設定をしています
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
