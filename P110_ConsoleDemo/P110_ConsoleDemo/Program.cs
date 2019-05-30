using System;
using System.Text;

namespace P110_ConsoleDemo
{
    #region Subjects
    //enum - sadalamaq
    //struct
    //Generic type
    //interface

    //Collections & Collections.Generic namespace

    //delegate
    //event

    //Thread, Task
    //Reflection
    #endregion

        
    class Program
    {
        #region Practice - Enum

        //enum Players { Alibaba, Anqut, Baba };

        #endregion
        static void Main(string[] args)
        {
            #region Enums
            //underlying type - int (default)
            //[Flags]
            //public enum Months : byte { NoMonth = 0, Yanvar = 0x1, Fevral = 0x2, Mart = 0x4, Aprel = 0x8 }

            //0001
            //0010
            //0100
            //1000

            // | or = 0101
            // & and = 0000

            //public enum AjaxErrors { NotFound = 404, ArgumentError = 401, Unauthorized = 410 }

            //Console.WriteLine(person.GetType());
            //Console.WriteLine(typeof(Program));
            //Person person = new Person(Months.Iyul);
            //Console.WriteLine(person.FavMonths);

            //foreach (var item in Enum.GetNames(typeof(AjaxErrors)))
            //{
            //    Console.WriteLine(item);
            //}

            //byte a = 0b1111;
            //3462 = 3 * 10^3 + 4 * 10^2 + 6 * 10^1 + 2 * 10^0
            //1011 = 1 * 2 ^ 3 + 0 * 2^2 + 1 * 2^1 + 1 * 2^0 = 11

            //foreach (var item in Enum.GetValues(typeof(AjaxErrors)))
            //{
            //    //AjaxErrors month = (AjaxErrors)item;
            //    //Console.WriteLine((int)month);

            //    Console.WriteLine((int)(AjaxErrors)item);
            //}
            #endregion

            #region Nullable value types
            //int? a = null;
            //char? c = null;
            //bool? b = null;

            //int[] demo;
            #endregion

            #region Structs

            //Position position = new Position(10, 20, 35);
            //Position position2 = new Position(5, 2, 3);

            //Console.WriteLine(position > position2);

            #endregion

            #region Generics
            //Queue users = new Queue(10);
            //users.Enqueue(20);
            //users.Enqueue(40);
            //users.Enqueue(77);

            //Queue positions = new Queue(15);
            //positions.Enqueue(new Position(10, 15, 20));
            //positions.Enqueue(new Position(5, 7, 1));
            //positions.Enqueue(new Position(3, 1, 12));

            //Console.WriteLine((Position)positions.Dequeue());
            //Console.WriteLine((Position)positions.Dequeue());

            //Queue<string> queue2 = new Queue<string>(10);
            //queue2.Enqueue("Samir");
            //queue2.Enqueue("Shems");
            //queue2.Enqueue("Elmar");

            //Console.WriteLine(queue2.Dequeue());
            //Console.WriteLine(queue2.Dequeue());

            //Queue<Person, Student> queue3 = new Queue<Person, Student>(10);
            //queue3.Enqueue(new Student("samir"));
            //queue3.Enqueue(new Position(7, 9, 5));

            //Console.WriteLine(queue3.Dequeue());
            #endregion

            #region Interface

            //int[] numbers = { 15, 10, 2, 3,  }; //O(n^2)
            //string[] words = {"Medis", "Bebis", "Elis", "Cebis"};

            //SortArray(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Practice - Enum

            //Testing testing = new Testing();
            //Console.WriteLine(Testing.Players.Alibaba); //Alibaba
            //Console.WriteLine((int)Testing.Players.Alibaba); //0
            //Console.WriteLine(Enum.GetName(typeof(Testing.Players),1)); //Anqut
            //foreach(string p in Enum.GetNames(typeof(Testing.Players)))
            //{
            //    Console.WriteLine(p);
            //}; //Alibaba, Anqut, Baba

            #endregion

            #region  Practice - Nullable Types

            //Testing testing = new Testing();
            //Console.WriteLine(testing.number); // null
            //Console.WriteLine(testing.number.HasValue); //false

            #endregion

            #region Practice - Struct

            //Testing2 testing2 = new Testing2("Alibaba", 90);
            //Console.WriteLine(testing2.ToString());

            #endregion

            #region Practice - Generics

            //Coding<int> coding = new Coding<int>();
            //int result = coding.MakeSum(5);
            //Console.WriteLine(result);

            //Coding<string> coding = new Coding<string>();
            //string result = coding.MakeSum("text");
            //Console.WriteLine(result);

            #endregion
        }

        //static void SortArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int minIndex = i;
        //        for (int j = i+1; j < array.Length; j++)
        //        {
        //            if(array[j] < array[minIndex])
        //            {
        //                minIndex = j;
        //            }
        //        }

        //        Swap(array, i, minIndex);
        //    }
        //}

        //static void Swap(int[] array, int i, int j)
        //{
        //    int temp = array[i];
        //    array[i] = array[j];
        //    array[j] = temp;
        //}
    }

    

    public class Testing
    {
        #region Practice - Enum
        public enum Players { Alibaba, Anqut, Baba };

        #endregion

        #region  Practice - Nullable Types

        //public int? number = null;

        #endregion

    }

    #region  Practice - Struct

    //public struct Testing2
    //{
    //    public string Name;
    //    public int Age;

    //    public Testing2(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name: {Name} \n Age: {Age}";
    //    }
    //}

    #endregion

    #region  Practice - Generics

    //public class Coding<T>
    //{
    //public T Sum { get; set; }

    //    public T MakeSum(T value)
    //    {
    //        return value;
    //    }
    //}

    //public class Coding<T> where T: class
    //{
    //    public T Sum { get; set; }

    //    public T MakeSum(T value)
    //    {
    //        return value;
    //    }
    //}

    #endregion





    //constraint - qadağa
    //class Queue<T, U> 
    //        where T : Person, new()
    //        where U : class, new() 
    //{
    //    private readonly T[] _queue;

    //    private int Tail = 0;
    //    private int Head = 0;

    //    public Queue(int maxLenght)
    //    {
    //        _queue = new T[maxLenght];
    //    }

    //    public void Enqueue(T item)
    //    {
    //        if(Tail < _queue.Length)
    //        {
    //            _queue[Tail++] = item;
    //            return;
    //        }

    //        throw new IndexOutOfRangeException("Queue is full");
    //    }

    //    public T Dequeue()
    //    {
    //        return _queue[Head++];
    //    }
    //}

    //struct Position
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z { get; set; }
    //    public int Area { get { return X * Y * Z; } }

    //    public Position(int x, int y, int z)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;
    //    }

    //    public static bool operator >(Position position, Position position2)
    //    {
    //        return position.Area > position2.Area;
    //    }

    //    public static bool operator <(Position position, Position position2)
    //    {
    //        return position.Area < position2.Area;
    //    }

    //    public void Demo()
    //    {
    //        Console.WriteLine("sdfsds");
    //    }

    //    public override string ToString()
    //    {
    //        return $"X: {X}, Y: {Y}, Z: {Z}";
    //    }
    //}

    //class Person { }
    //class Student : Person
    //{
    //    public Student()
    //    {

    //    }
    //    public Student(string s)
    //    {
    //    }
    //}
    //class Instructor : Person { }
    //class CodeInstructor : Instructor { }
}

