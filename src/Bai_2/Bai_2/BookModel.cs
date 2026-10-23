using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2
{
    internal class BookModel
    {
        public string BookId { get; set; } = "";
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CoverPath { get; set; } = "";

        public decimal TotalValue => Price * Quantity;
    }
}
