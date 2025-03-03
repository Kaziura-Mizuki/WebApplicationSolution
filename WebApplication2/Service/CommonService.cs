using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using System;

namespace WebApplication2.Service
{
    public class CommonService
    {
        private readonly AppDbContext _context;

        public CommonService(AppDbContext context)
        {
            _context = context;
        }

        /*
        public int GetNextSequenceValue(string seq_name)
        {
            FormattableString sql = $"SELECT NEXT VALUE FOR dbo.{seq_name};";
            var result = _context.Database.SqlQuery<int>(sql).SingleAsync().Result;
            return result;
        }*/

        public async Task<int> GetNextSequenceValue(string seq_name)
        {
            var sql = $"SELECT NEXT VALUE FOR dbo.{seq_name};";
            var result = await _context.Database.ExecuteSqlRawAsync(sql);
            var nextValue = await _context.Set<SequenceResult>().FromSqlRaw(sql).AsNoTracking().FirstOrDefaultAsync();
            return nextValue?.Value ?? 0;
        }
        
        public class SequenceResult
        {
            public int Value { get; set; }
        }

    }
}
