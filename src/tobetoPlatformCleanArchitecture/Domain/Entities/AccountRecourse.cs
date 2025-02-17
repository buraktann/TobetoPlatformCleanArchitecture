﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class AccountRecourse : Entity<int>
{
    public int AccountId { get; set; }
    public int ApplicationId { get; set; }
    public int ApplicationStepId { get; set; }

    public AccountRecourse()
    {
        
    }

    public AccountRecourse(int id, int accountId, int applicationId, int applicationStepId) : this()
    {
        Id = id;
        AccountId = accountId;
        ApplicationId = applicationId;
        ApplicationStepId = applicationStepId;
    }
}
