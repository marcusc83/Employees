﻿using System.ComponentModel.DataAnnotations;

namespace Employees.Model
{
    public class MyEmployees
    {
        [Key]
        public int empId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }

    }
}
