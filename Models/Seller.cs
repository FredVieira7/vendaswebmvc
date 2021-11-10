﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }
        public string Email { get; set; }

        [DisplayName("Salário Base")]
        public double BaseSalary { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
                
        }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(SalesRecord => SalesRecord.Date >= initial && SalesRecord.Date <= final)
                .Sum(SalesRecord => SalesRecord.Amount);
        }
    }
}
