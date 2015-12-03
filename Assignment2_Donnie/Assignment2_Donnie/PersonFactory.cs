namespace Assignment2_Donnie
{
    public static class PersonFactory
    {
        public static Person Create()
        {
            return createPerson(null);
        }

        private static Person createPerson(Person firstPerson)
        {
            bool first = firstPerson == null;
            Person person = new Person();
            person.FirstName = MyConsole.ReadString("First Name");
            person.LastName = first ? MyConsole.ReadString("Last Name") : firstPerson.LastName;
            person.Age = MyConsole.ReadInt("Age");
            person.Spouse = first ? createSpouse(person) : firstPerson;
            return person;
        }

        private static Person createSpouse(Person person)
        {
            return MyConsole.ReadBool("Married?") ? createPerson(person) : null;
        }
    }
}