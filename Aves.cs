namespace Lab15
{
    public class Aves:Animales
    {
        public string Vuela {  get; set; }
        public string P_Incubacion { get; set; }

        public Aves()
        {
            Vuela = string.Empty;
            P_Incubacion = string.Empty;
        }
    }
}
