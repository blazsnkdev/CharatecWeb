namespace CharatecWeb.Backend.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }
        public string? Memoria { get; set; }
        public string? Pantalla { get; set; }
        public string? SistemaOperativo { get; set; }

        public int? MarcaId { get; set; }
        public int? ProcesadorId { get; set; }
        public int? TarjetaVideoId { get; set; }

        public string? NumeroParte { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }

        public bool? Oferta { get; set; }
        public bool? UltimaUnidades { get; set; }
        public bool? Oled { get; set; }
        public bool? Ia { get; set; }
        public bool? Tactil { get; set; }

        public string? ImagenUrl { get; set; }

        // Navegación: EF Core las relaciona mediante las claves foráneas
        public Marca? Marca { get; set; }
        public Procesador? Procesador { get; set; }
        public TarjetaVideo? TarjetaVideo { get; set; }
    }
}
