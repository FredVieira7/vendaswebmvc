using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        [DisplayName("Nome do Departamento")]
        public string Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));
        }

    }
}
