using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WcfService1.Model
{
    public class User
    {
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        
        [Display(Name = "Phone Number")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

       
        [Display(Name = "Description")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Display(Name = "Rank")]
        public double AVGrank { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }

        [Display(Name = "Video")]
        public string Video { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }
}