namespace WebHelloMVC1.Models
{
    public class Person
    {
        static Person() 
        {
            All = [
                new Person() { Id = 1, Name = "Nick", Description = "Good", Phone = "+7"},
                new Person() { Id = 2, Name = "Rick", Description = "Bad", Phone = "+34"},
                new Person() { Id = 3, Name = "Kayl", Description = "Avarage", Phone = "+48"},
                new Person() { Id = 4, Name = "Rown", Description = "Briliant", Phone = "+99"}
            ]; 
        }
        public static IList<Person> All { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
    }
}
