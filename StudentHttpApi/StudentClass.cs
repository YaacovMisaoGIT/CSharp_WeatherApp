namespace StudentHttpApi
{
    public class StudentClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public StudentClass(string name, string surname)
        {
            Name = name;
            Surname = surname;  
        }

    }
}
