namespace Assignment2_Donnie
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person Spouse { get; set; }

        public void ReadAndSetFirstName() { FirstName = MyConsole.ReadString("First Name"); }
        public void ReadAndSetLasttName() { LastName = MyConsole.ReadString("Last Name"); }
        public void ReadAndSetAge() { Age = MyConsole.ReadInt("Age"); }
        public bool ReadIsMarried() { return MyConsole.ReadBool("Married?"); }
    }
}