using Microsoft.Extensions.Primitives;

namespace DSU24.Models.Dtos
{
    public class GeometryDto
    {
        public string Type { get; set; }
        public List<List<double>> Coordinates { get; set; }
    }
}
