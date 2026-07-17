public class SortingMechanism
{
    public delegate int Comparison<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }

        public int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        public int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }

    }
}