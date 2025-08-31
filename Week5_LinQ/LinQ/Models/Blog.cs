using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models;

public class Blog //Principle Entity
{
    public int Id{ get; set; }   // Principle key

    //[Column(TypeName ="varchar(200)")]
    [Required, MaxLength(1000)]
    public string Url { get; set; }

    public List<Post> Posts { get; set; } // Collection Navigation Property

}


