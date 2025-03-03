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

        public int GetNextSequenceValue(string seq_name)
        {
            FormattableString sql = $"SELECT NEXT VALUE FOR dbo.{seq_name};";
            var result = _context.Database.SqlQuery<int>(sql).SingleAsync().Result;
            return result;
        }

    }
}
