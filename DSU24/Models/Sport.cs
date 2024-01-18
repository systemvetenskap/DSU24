using System.ComponentModel.DataAnnotations;

namespace DSU24.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SecretCost { get; set; }
        public decimal Price { get; set; }

        // navigation property
        public virtual Season? Season{ get; set; } // =  nullable
    }
}
