﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Exam : Entity<int>
{
    public string Name { get; set; }
    public int Priority { get; set; }
    public bool Visibility { get; set; }
    public string Description { get; set; }
    public byte NumberOfQuestions { get; set; }
    public DateTime StartingTime { get; set; }
    public DateTime EndTime { get; set; }
    public short Duration { get; set; }

    

    public Exam()
    {
        
    }

    public Exam(int id, string name, int priority, bool visibility, string description, byte numberOfQuestions, DateTime startingTime, DateTime endTime, short duration) :this()
    {
        Id = id;
        Name = name;
        Priority = priority;
        Visibility = visibility;
        Description = description;
        NumberOfQuestions = numberOfQuestions;
        StartingTime = startingTime;
        EndTime = endTime;
        Duration = duration;
    }
}
