namespace WebHelloMVC1.Models
{
    public class Names
    {
        public static List<string> AllNames { get; set; }

        static Names()
        {
            AllNames = ["Anatoly", "Nick", "Ann", "Jack", "Maria"];
        }
    }
}
