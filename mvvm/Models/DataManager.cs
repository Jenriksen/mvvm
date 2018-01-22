namespace mvvm.Models
{
    class DataManager
    {
        public Person ImportantPerson { get; set; }

        public DataManager()
        {
            ImportantPerson = new Person {FirstName = "Anders", LastName = "And"};
        }
    }
}