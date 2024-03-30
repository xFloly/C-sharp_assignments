namespace Ex03_Generics
{
    internal class Person
    {
        private string _name = "Jan";

        private string _secondName = "Nowak";

        public Person() { }

        Person(string  name, string secondName)
        {
            _name = name;
            _secondName = secondName;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        public static void ChangeName(string newName, string newSecondName, Person p)
        {
            p._name = newName;
            p._secondName = newSecondName;
        } 

        public static void CreateNewPerson(string newName, string newSecondName, ref Person p) {
            p = new Person(newName, newSecondName);
        }

        public static void DeletePerson(ref Person? p) {
            p = null;
        }

        public override string ToString()
        {
            return $"{_name+" "+_secondName}" ?? "osoba niezdefiniowana";
        }
    }
}
