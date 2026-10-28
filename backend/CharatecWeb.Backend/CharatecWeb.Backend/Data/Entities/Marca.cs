namespace CharatecWeb.Backend.Data.Entities
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();

    }
}
