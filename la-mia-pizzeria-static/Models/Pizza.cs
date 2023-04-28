namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        public Pizza(string nome, string descrizione, string image, double price)
        {
            Nome = nome;
            Descrizione = descrizione;
            Image = image;
            Price = price;
        }
    }
}
