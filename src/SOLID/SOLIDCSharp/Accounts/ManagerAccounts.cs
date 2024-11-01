﻿using SOLIDCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com";
            employee.IsManager = true;
            return employee;
        }
    }
}
