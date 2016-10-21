using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.PimcoTest
{
    //public class FilteringEnumerator:IObjectTest, IEnumerator
    public class MyFruit
    {
        private string _name;
        private double _price;
        public MyFruit(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }
    }

    public class PriceTest : IObjectTest
    {
        double price;
        public PriceTest(double _price)
        {
            price = _price;
        }

        public bool Test(object ob)
        {
            return (double) ob >= price;
        }
    
    }

    public class MyPriceTest<T>: IObjectTest
        //where T: class
    {
        public T Value { get; set; }
        public string Name { get; set; }
        public MyPriceTest(T value)
        {
            //Name = name;
            Value = value;
        }

        public bool Test(object o)
        {
            //return  >= price;
            return (Value as object) == o;
        }

    }

    public class FilteringEnumerator : IEnumerator
    {
        IEnumerator _myEnmerator;
        IObjectTest _myTest;

        public FilteringEnumerator(IEnumerator myEnmerator, IObjectTest myTest)
        {
            _myEnmerator = myEnmerator;
            _myTest = myTest;
        }

        public bool Test<T>(T item)
        {
            //while (_myEnmerator.MoveNext())
            {
                //T item = _myEnmerator.Current;
                if (_myTest.Test(item))
                    return true;
                return false;

            }
        }

        public void Reset()
        {
            _myEnmerator.Reset();
        }

        //public bool MoveNext()
        //{
        //    return _myEnmerator.MoveNext();
        //}

        //public object Current { 
        //    get {
        //    while (MoveNext())
        //    {
        //        if (_myTest.Test(Current))
        //            return Current;
        //    }
        //    return null;
        //} }

        public bool MoveNext()
        {
            while(_myEnmerator.MoveNext())
            {
                if(_myTest.Test(Current))
                    return true;
            }

            return false;
        }

        public object Current
        {
            get { return _myEnmerator.Current; }
        }


        public static void Main()
        { 
            //List<MyFruit> fruits = new List<MyFruit>();
            //fruits.Add(new MyFruit("Apple", 0.5));
            //fruits.Add(new MyFruit("Orange", 0.2));
            //fruits.Add(new MyFruit("Banana", 0.3));
            //List<MyFruit> cheapFruits = new List<MyFruit>();

            List<double> fruits = new List<double>();
            fruits.Add(0.5);
            fruits.Add(0.4);
            fruits.Add(0.2);
            fruits.Add(0.3);
            fruits.Add(0.1);
            //List<MyFruit> cheapFruits = new List<MyFruit>();

            List<double> cheapFruits = new List<double>();


            //IEnumerator<MyFruit> ie = fruits.GetEnumerator();

            IEnumerator<double> ie = fruits.GetEnumerator();
            IObjectTest test = new PriceTest(0.3);

            FilteringEnumerator filter = new FilteringEnumerator(ie, test);

            while (filter.MoveNext())
            {
                //MyFruit cheapFruit = ie.Current;
                double cheapFruit = ie.Current;
                cheapFruits.Add(cheapFruit);
            }

            //foreach(MyFruit fruit in cheapFruits)
            //{
            //    Console.WriteLine(fruit.GetName() + ": " + fruit.GetPrice());
            //}

            foreach (double fruit in cheapFruits)
            {
                Console.WriteLine(fruit);
            }


            //IObjectTest priceTest = new MyPriceTest<MyFruit>(new MyFruit("Apple", 0.3))

            Console.Read();
        
        }

        //public bool Test(object o)
        //{
        //    return true;
        //}


       
    }
}
