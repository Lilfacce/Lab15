namespace Lab15
{
    public class Serpientes:Animales
    {
        public string Veneno {  get; set; }
        public string Longitud {    get; set; }

        public Serpientes() 
        {
            Veneno = string.Empty;
            Longitud = string.Empty;
        }
    }
}
