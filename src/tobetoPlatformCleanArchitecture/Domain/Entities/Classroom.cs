﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Classroom : Entity<int>
{
    public string Name { get; set; }
    public byte MaximumCapacity { get; set; }

    public Classroom()
    {
        
    }

    public Classroom(int id, string name, byte maximumCapacity):this()
    {
        Id = id;
        Name = name;
        MaximumCapacity = maximumCapacity;
    }
}
