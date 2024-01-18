namespace DSU24.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navigation property
        public virtual ICollection<Sport> Sports { get; set; }
    }
}
