using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do campo nome deve ser entre {2} e {1} caracteres.")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O campo e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Entre com um e-mail válido.")]
        public string Email { get; set; }

        [DisplayName("Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "O campo salário base é obrigatório.")]
        [Range(100.0, 50000.0, ErrorMessage = "O valor do salário do vendedor deve estar entre 100,00 e 50000,00 reais.")]
        public double BaseSalary { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "O campo data de nascimento é obrigatório.")]
        [DataType(DataType.Date)]
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
