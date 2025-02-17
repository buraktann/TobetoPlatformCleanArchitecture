﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class LearningPath : Entity<int>
{
    public string Name { get; set; }
    public bool Visibility { get; set; }
    public DateTime StartingTime { get; set; }
    public DateTime EndTime { get; set; }

    public LearningPath()
    {

    }

    public LearningPath(int id, string name, bool visibility, DateTime startingTime, DateTime endTime) : this()
    {
        Id = id;
        Name = name;
        Visibility = visibility;
        StartingTime = startingTime;
        EndTime = endTime;
    }
}

