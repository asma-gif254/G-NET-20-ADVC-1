using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace G_NET_20_ADVC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1: What is a generic class? Why use generics?
            // Generic class uses type parameters that are replaced with actual types when you create an instance.The type parameter T acts as a placeholder.
            // USE IT FOR (Type Safety, Performance, IntelliSense, Code Reuse).


            // Q2: Write a generic class Container<T> with Add and Get methods.
            //var container = new Container<string>();

            //container.Add("Asmaa");
            //container.Add("Mohammed");

            //string value = container.Get(0);  


            // Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            // Generic classes can have multiple type parameters, examples: Dictionary<TKey, TValue>, Tuple<T1, T2>
            //var person = new Pair<string, int>("Ahmed", 25);
            //Console.WriteLine($"{person.First} is {person.Second} years old");

            //var (name, age) = person;
            //Console.WriteLine($"{name}: {age}");


            // Q4 & 5 : What is a generic method? Write Swap<T> method? MAX Method
            // declares its own type parameter(s). It can exist in both generic and non-generic classes. The compiler often infers the type argument.

            //int x = 5, y = 10;
            //Utilities.Swap(ref x, ref y);  // Compiler infers T = int
            //Console.WriteLine($"x={x}, y={y}"); // x=10, y=5

            //string a = "Hello", b = "World";
            //Utilities.Swap<string>(ref a, ref b); // Explicit type

            //int bigger = Utilities.Max(10, 20);



            // What is a generic interface? Write IRepository<T>
            // define contracts with type parameters. Classes implementing them specify the actual types. 
        }
            public class UserRepository : IRepository<User>
        {
            private readonly List<User> _users = new();

            public User? GetById(int id)
                => _users.FirstOrDefault(u => u.Id == id);

            public IEnumerable<User> GetAll() => _users;

            public void Add(User entity) => _users.Add(entity);

            public void Update(User entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }
        }


    }

    public class User
    {
        internal readonly int Id;
    }
}

