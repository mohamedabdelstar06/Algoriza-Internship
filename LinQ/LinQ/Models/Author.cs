﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models;
public class Author
{
    public int Id { get; set; }
    public string FirstName{ get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
}
