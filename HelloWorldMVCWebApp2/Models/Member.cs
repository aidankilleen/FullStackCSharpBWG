﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMVCWebApp2.Models
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Active { get; set; }

        public override string? ToString()
        {
            return $"Id: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"Email: {Email}\n" +
                    $"{(Active ? "Active" : "Inactive")}\n";
        }
    }
}