using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using VendasWebMVC.Services.Exceptions;

namespace VendasWebMVC.Services
{
    public class SellerService
    {
        private readonly VendasWebMVCContext _context;

        public SellerService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertSellerAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveSellerAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);

                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("Erro ao excluir vendedor(a), o mesmo possui vendas cadastradas no sistema");
            }
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
            {
                throw new NotFoundException("O Id informado não existe.");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException error)
            {
                throw new DbConcurrencyException(error.Message);
            }

            
        }
    }
}
