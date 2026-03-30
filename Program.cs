using G_NET_12_Ad01.Question_11;

namespace G_NET_12_Ad01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //Q1: What is a generic class? Why use generics?
            //Answer : the genarics is a Unique data tybe it allow us to use multable data tybe :
            //why? We avoid repetition


            #endregion
            #region Question 2

            //Q2:Write a generic class Container<T> with Add and Get methods.
            //Answer : ==>


            #endregion
            #region Question 3

            //Q3:What are multiple type parameters? Write Pair<TKey,TValue > ..
            //Answer : ==>


            #endregion
            #region Question 4

            //Q4: What is a generic method? Write Swap<T> method.
            //Answer : ==>
            //int a = 1; int b = 5;
            //Console.WriteLine("After swap");
            //Question_4.Swap<int>(ref a, ref b);
            //Console.WriteLine($"a = {a} : b = {b}");


            #endregion
            #region Question 5

            //Q5: Write a generic method FindMax<T> that finds maximum value
            //Answer : ==>
            //int[] arrs = { 10, 5, 22, 8, 13, 20, 45, 5, 2 };
            //Question_5.Printarr(arrs);
            //Console.WriteLine();
            //Console.WriteLine($"the maximum value un array = {Question_5.findMax(arrs)}");

            #endregion
            #region Question 6

            //Q6: What is a generic interface? Write IRepository<T>
            //Answer : ==>
            // Genaric Interface is : it is a unique interface can be hold a multable data tybe

            #endregion
            #region Question 7

            //Q7: What is the 'struct' constraint? Write an example
            //Answer : ==>
            // the struct constraint it must be value type only
            //Question_7<int> str = new(10);
            //Question_7<decimal> strs = new(10M);

            #endregion
            #region Question 8

            //Q8: What is the 'class' constraint? Write an example.
            //Answer : ==>
            // the class constraint it must be refernce type only
            //Question_8<string> str = new("aaa");


            #endregion
            #region Question 9

            //Q9: What is the 'new()' constraint? Write an example.
            //Answer : ==>
            // the new() constraint it must have a parameterless constructor


            #endregion
            #region Question 10

            //Q9: What is the interface constraint? Write an example.
            //Answer : ==>
            // the interface constraint it must implement interface Like Icomparable And Ienumerable.


            #endregion
            #region Question 11

            //Q11: What is the base class constraint? Write an example.
            //Answer : ==>
            // the interface constraint it must inherit from base class
            //AnimalShelter<Dog> dogShelter = new();
            //dogShelter.Add(new Dog("asass"));
            //AnimalShelter<Cat> catShelter = new();
            //catShelter.Add(new Cat("sasa"));


            #endregion
            #region Question 12

            //Q12: How do you apply multiple constraints? Write an example.
            //Answer : ==> applaying multiple constraints we can do it by using comma (,) between the constraints


            #endregion
            #region Question 13

            //Q13: What does the 'default' keyword do in generics?
            //Answer : ==> the default keyword in generics is used to return the default value of a type parameter. For reference types, it returns null; for value types, it returns the default value (e.g., 0 for int, false for bool).

            #endregion
            #region Question 14

            //Q14: Write a SafeList<T> that returns default when the index is invalid
            //Answer : ==> private List<T> items = new();
            //         public void Add(T item) => items.Add(item) : default;
            //         return default when the index is invalid


            #endregion
            #region Question 15

            //Q15: What is covariance? Explain the 'out' keyword.
            //Answer : ==> covariance allows you to use a more derived type than originally specified. Marked with out keyword
            //         ==> out Keyword is makes the class just recieve , just get not set


            #endregion
            #region Question 16

            //Q16: What is contravariance? Explain the 'in' keyword.
            //Answer : ==> Contravariance allows you to use a less derived type than originally specified. Marked with in keyword.
            //         ==> in Keyword can only appear in input positions.

            #endregion
            #region Question 17

            //Q17: What is the difference between covariance and contravariance
            //Answer : covariance->  output only , producer of T
            //         contravariance-> input only , consumer of T

            #endregion




        }
    }
}
