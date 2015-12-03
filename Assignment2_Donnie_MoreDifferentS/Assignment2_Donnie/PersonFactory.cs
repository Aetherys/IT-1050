namespace Assignment2_Donnie
{
    public static class PersonFactory
    {
        public static Person Create()
        {
            Person person = new Person();
            person.ReadAndSetFirstName();
            person.ReadAndSetLasttName();
            person.ReadAndSetAge();

            if (person.ReadIsMarried())
            {
                person.Spouse = new Person();
                person.Spouse.ReadAndSetFirstName();
                person.Spouse.LastName = person.FirstName;
                person.Spouse.ReadAndSetAge();
                person.Spouse.Spouse = person;
            }

            return person;
        }
    }
}