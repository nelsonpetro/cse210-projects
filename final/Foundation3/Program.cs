using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("55 Tech St", "Pasadena", "CA", "78923");
        Address address2 = new Address("123 Fake St", "Salt Lake", "UT", "12345");
        Address address3 = new Address("456 Cold St", "Pocatello", "ID", "44231");

        Event lecture = new Lecture("Impact of Electric Vehicles on the Global Warming", "Lecture included on the Climatic Change symposium", new DateTime(2023, 06, 20), new TimeSpan(14,00,00), address1, "Nelson Petro", 200);
        Event reception = new Reception("Josh and Rachel Weeding", "Reception for the wedding of Josh and Rachel. Formal dressing.", new DateTime(2023, 07, 23), new TimeSpan(18,00,00), address2, "weding@email.com / +1 (801) 562 5566");
        Event outdoor = new OutdoorGathering("Camping on rainy night!", "Camping during a rainy night with family and friends.", new DateTime(2023, 12, 31), new TimeSpan(19,00,00), address3, "Cloudy night with 100% probability of precipitation");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        foreach(Event e in events)
        {
            Console.WriteLine("Short Description\n");
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("Standard Details\n");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine("Full Details\n");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine("=========================================================================================\n");
        }

    }
}