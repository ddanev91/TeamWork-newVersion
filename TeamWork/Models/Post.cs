﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using TeamWork.Models;
using System.Net;



namespace TeamWork.Models
{
   
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

     
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }
    }

    
}