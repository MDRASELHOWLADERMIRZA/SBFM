using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBFM.Domain.Entities
{
    public class Income
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public DateTime IncomeDate { get; set; }

        public string? CustomerId { get; set; }

        public string? ReferenceNo { get; set; }

        public string? Notes { get; set; }

        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
    }
}
