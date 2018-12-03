﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryStandard.Models
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(200, MinimumLength = 1)]
        public string LastName { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}