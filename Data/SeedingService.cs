using System;
using System.Linq;
using VendasWebMVC.Models;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Data
{
    public class SeedingService
    {
        private VendasWebMVCContext _context;

        public SeedingService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(new int(), "Computadores");
            Department d2 = new Department(new int(), "Eletrônicos");
            Department d3 = new Department(new int(), "Moda");
            Department d4 = new Department(new int(), "Livros");
            Department d5 = new Department(new int(), "Casa");

            Seller s1 = new Seller(new int(), "João", "joao@gmail.com", 1100.00, new DateTime(1995, 2, 10), d1);
            Seller s2 = new Seller(new int(), "Fred", "fred@gmail.com", 1250.00, new DateTime(1997, 5, 17), d1);
            Seller s3 = new Seller(new int(), "Maria", "maria@gmail.com", 1300.00, new DateTime(1998, 3, 2), d2);
            Seller s4 = new Seller(new int(), "Julia", "julia@gmail.com", 1350.00, new DateTime(1989, 1, 24), d2);
            Seller s5 = new Seller(new int(), "Pedro", "pedro@gmail.com", 1370.00, new DateTime(1985, 9, 28), d3);
            Seller s6 = new Seller(new int(), "Cleber", "cleber@gmail.com", 1000.00, new DateTime(1998, 2, 19), d3);
            Seller s7 = new Seller(new int(), "Carlos", "carlos@gmail.com", 1500.00, new DateTime(2000, 7, 7), d4);
            Seller s8 = new Seller(new int(), "Beatriz", "beatriz@gmail.com", 1550.00, new DateTime(1994, 5, 11), d4);
            Seller s9 = new Seller(new int(), "Joana", "joana@gmail.com", 1260.50, new DateTime(1992, 5, 17), d5);
            Seller s10 = new Seller(new int(), "Antonio", "antonio@gmail.com", 1120.90, new DateTime(1992, 11, 15), d5);

            SalesRecord r1 = new SalesRecord(new int(), new DateTime(2021, 09, 1), 11000.00, SalesStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(new int(), new DateTime(2021, 09, 1), 7000.00, SalesStatus.Pendente, s1);
            SalesRecord r3 = new SalesRecord(new int(), new DateTime(2021, 09, 2), 5500.00, SalesStatus.Cancelado, s2);
            SalesRecord r4 = new SalesRecord(new int(), new DateTime(2021, 09, 2), 1650.00, SalesStatus.Faturado, s2);
            SalesRecord r5 = new SalesRecord(new int(), new DateTime(2021, 09, 3), 1800.00, SalesStatus.Faturado, s3);
            SalesRecord r6 = new SalesRecord(new int(), new DateTime(2021, 09, 3), 3456.00, SalesStatus.Faturado, s3);
            SalesRecord r7 = new SalesRecord(new int(), new DateTime(2021, 09, 6), 679.00, SalesStatus.Cancelado, s4);
            SalesRecord r8 = new SalesRecord(new int(), new DateTime(2021, 09, 6), 6785.00, SalesStatus.Pendente, s4);
            SalesRecord r9 = new SalesRecord(new int(), new DateTime(2021, 09, 9), 1757.00, SalesStatus.Pendente, s5);
            SalesRecord r10 = new SalesRecord(new int(), new DateTime(2021, 09, 9), 7893.00, SalesStatus.Faturado, s6);
            SalesRecord r11 = new SalesRecord(new int(), new DateTime(2021, 09, 10), 5664.00, SalesStatus.Faturado, s6);
            SalesRecord r12 = new SalesRecord(new int(), new DateTime(2021, 09, 11), 7896.56, SalesStatus.Faturado, s7);
            SalesRecord r13 = new SalesRecord(new int(), new DateTime(2021, 09, 11), 1568.60, SalesStatus.Cancelado, s7);
            SalesRecord r14 = new SalesRecord(new int(), new DateTime(2021, 09, 12), 15000.00, SalesStatus.Pendente, s8);
            SalesRecord r15 = new SalesRecord(new int(), new DateTime(2021, 09, 14), 12345.00, SalesStatus.Faturado, s8);
            SalesRecord r16 = new SalesRecord(new int(), new DateTime(2021, 09, 14), 1235.00, SalesStatus.Faturado, s9);
            SalesRecord r17 = new SalesRecord(new int(), new DateTime(2021, 09, 14), 478.00, SalesStatus.Pendente, s9);
            SalesRecord r18 = new SalesRecord(new int(), new DateTime(2021, 09, 17), 5780.00, SalesStatus.Pendente, s10);
            SalesRecord r19 = new SalesRecord(new int(), new DateTime(2021, 09, 17), 24572.35, SalesStatus.Cancelado, s10);
            SalesRecord r20 = new SalesRecord(new int(), new DateTime(2021, 09, 18), 1234.00, SalesStatus.Faturado, s1);
            SalesRecord r21 = new SalesRecord(new int(), new DateTime(2021, 09, 19), 3456.00, SalesStatus.Cancelado, s2);
            SalesRecord r22 = new SalesRecord(new int(), new DateTime(2021, 09, 20), 1997.99, SalesStatus.Faturado, s3);
            SalesRecord r23 = new SalesRecord(new int(), new DateTime(2021, 09, 20), 9765.75, SalesStatus.Faturado, s4);
            SalesRecord r24 = new SalesRecord(new int(), new DateTime(2021, 09, 22), 4315.00, SalesStatus.Cancelado, s5);
            SalesRecord r25 = new SalesRecord(new int(), new DateTime(2021, 09, 23), 6547.00, SalesStatus.Faturado, s6);
            SalesRecord r26 = new SalesRecord(new int(), new DateTime(2021, 09, 25), 8445.00, SalesStatus.Pendente, s7);
            SalesRecord r27 = new SalesRecord(new int(), new DateTime(2021, 09, 25), 2364.60, SalesStatus.Faturado, s8);
            SalesRecord r28 = new SalesRecord(new int(), new DateTime(2021, 09, 27), 25894.15, SalesStatus.Pendente, s9);
            SalesRecord r29 = new SalesRecord(new int(), new DateTime(2021, 09, 29), 17897.00, SalesStatus.Pendente, s10);
            SalesRecord r30 = new SalesRecord(new int(), new DateTime(2021, 09, 29), 1346.00, SalesStatus.Faturado, s1);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            _context.SalesRecord.AddRange(
                r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,
                r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,
                r21,r22,r23,r24,r25,r26,r27,r28,r29,r30
                );

            _context.SaveChanges();
        }
    }
}
