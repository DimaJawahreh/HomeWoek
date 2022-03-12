using DataAccess.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Entity
{
    [Table("Users")]
  public  class User
    {

        public int id { set; get; }
        [Required]
        [Display(Name ="Your Name")]
        public string Name { set; get; }
        [DataType(DataType.Password)]
        [Required]

        public string Password { set; get; }
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Required]
        [Display(Name="Confirm Password")]

        public string ConfirmPassword { set; get; }
        [BDValidation]
        [Display(Name ="Birth Date")]
        public DateTime BDate { set; get; }
    }
}
