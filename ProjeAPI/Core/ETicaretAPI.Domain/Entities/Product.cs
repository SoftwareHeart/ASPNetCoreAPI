using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Puan { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
