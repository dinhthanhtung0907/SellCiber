using System;

namespace BackEnd.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public int? ProductId { get; set; }
        public int Amount { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
