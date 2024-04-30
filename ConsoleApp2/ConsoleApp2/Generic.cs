using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct ComplexNumber<T> where T : INumber<T>
    {
        public T _real { get; private set; }
        public T _im { get; private set; }
        public ComplexNumber(T real, T im)
        {
            _real = real;
            _im = im;
        }
        public void Print()
        {
            Console.WriteLine($"{_real} + {_im}i");
        }
        public static ComplexNumber<T> operator +(ComplexNumber<T> value1, ComplexNumber<T> value2)
        {
            return new ComplexNumber<T>(value1._real + value2._real, value2._im + value2._im);
        }
        public static ComplexNumber<T> operator -(ComplexNumber<T> value1,ComplexNumber<T> value2)
        {
            return new ComplexNumber<T>(value1._real-value2._real, value1._im-value2._im);
        }
    }
    public class Point
    {
        private double _x;
        private double _y;
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point(double _x, double _y)
        {
            this._x = _x;
            this._y = _y;
        }

        public void Print()
        {
            Console.WriteLine($"(x={_x} , y={_y})");
        }
    
    }
    public class ListTest :IEnumerable
    {
        private   object[] _array;
        private int count=>_array?.Length ?? 0;
        public ListTest(object[] array)
        {
            _array = array;
        }
        public ListTest()
        {
           
        }
        public void Add(object item)
        {
             var arraydouble = _array ;
            _array = new object[_array?.Length+1 ?? 1];
           for(int i =0; i < _array.Length-1; i++)
            {
                _array[i] = arraydouble[i];
            }

            _array[_array.Length-1] = item;
        }
        public int Count => _array.Length;

        public bool IsReadOnly => false;

        public object this[int index] 
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index]= value;
            }
        }
        object[] ToArray() => _array;



         public int IndexOf(object item)
        {
            for(int i=0; i< _array.Length; i++)
            {
                if (_array[i]?.Equals(item) ?? false)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object item)
        {
            var arrayinsert = _array;
            _array = new object[_array?.Length + 1 ?? 1];
            for(int i=0; i< index + 1;i++)
            {
                _array[i] = arrayinsert[i];
            }
            _array[index] = item;
            for (int i =index+1; i< _array.Length; i++)
            {
                _array[i] = arrayinsert[i - 1];
            }
        }

        public void RemoveAt(int index)
        {
            if (_array?.Length > 0)
            {
                var arrayRemove = _array;
                _array = new object[_array?.Length - 1 ?? 0];
                for (int i = 0; i < index + 1; i++)
                {
                    _array[i] = arrayRemove[i];
                }
                _array = new object[_array?.Length - 1 ?? 0];
                for (int i =index; i< _array.Length-1; i++)
                {
                    _array[i] = arrayRemove[i + 1];
                }
            }

            
        }

       

        public void Clear()
        {
            _array = new object[0];
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i]?.Equals(item) ?? false)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(object[] array, int arrayIndex)
        {
            array = new object[arrayIndex];
            for (int i = 0; i < arrayIndex; i++)
            {

            }
        }

        public bool Remove(object item)
        {
          int index= IndexOf(item);
          RemoveAt(index);
            return index != -1;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    } 
}
