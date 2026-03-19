using System;
using System.ComponentModel;
using System.Data.Common;
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



            // Q 6:  What is a generic interface? Write IRepository<T>
            // define contracts with type parameters. Classes implementing them specify the actual types. 
        }
        //        public class UserRepository : IRepository<User>
        //    {
        //        private readonly List<User> _users = new();

        //        public User? GetById(int id)
        //            => _users.FirstOrDefault(u => u.Id == id);

        //        public IEnumerable<User> GetAll() => _users;

        //        public void Add(User entity) => _users.Add(entity);

        //        public void Update(User entity)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        public void Delete(int id)
        //        {
        //            throw new NotImplementedException();
        //        }
        //    }


        //}

        //public class User
        //{
        //    internal readonly int Id;
        //}



        // Q6: what is the 'struct' constraint? Write an example?
        //  where T : struct restricts T to value types only. Useful when you need value semantics (copy, no null)


        // Q7: CLASS : where T : class restricts T to reference types only. This allows T to be null and enables reference comparison.


        //Q 8: Where T : new() requires T to have a public parameterless constructor. This allows you to create instances of T inside the generic code. 

        // Q9: You can combine multiple constraints for a single type parameter, and have different constraints for different type parameters.

        //public class Mapper<TSource, TDest>
        //   where TSource : class
        //    where TDest : class, new()
        //     {
        //    public TDest Map(TSource source)
        //    {
        //        var dest = new TDest();
        //        return dest;
        //    }
        // }


        // Q : default keyword : gives you the default value of a type parameter T:

        // For reference types ( string, classes, interfaces) : default(T) is null.
        //For nullable value types(int?): default(T) is null.
        //For non‑nullable value types( int, bool, DateTime) : default(T) is their zero-initialized value(0, false).
        //For structs: all fields are zero-initialized.

        // Q: Write a SafeList<T> that returns default when the index is invalid.
        //public class SafeList<T>
        //{
        //    private readonly List<T> _items = new List<T>();

        //    public void Add(T item) => _items.Add(item);

        //    public T Get(int index)
        //    {
        //        return (index >= 0 && index < _items.Count) ? _items[index] : default!;
        //    }
        //    public T this[int index] => (index >= 0 && index < _items.Count) ? _items[index] : default!;
        //}



        // Q : Covariance allows you to use a more derived type where a base type is expected on output (return) positions.
        //Mark generic type parameters with out to make the interface/delegate covariant.
        //You can only use T in output positions (method return types, read-only members). You cannot accept T as a method parameter when marked out.

        public interface IReadOnlyBox<out T>
        {
            T Get();        
                            
        }

        IReadOnlyBox<string> sb = default!;
        IReadOnlyBox<object> ob = sb; 
    }

}


