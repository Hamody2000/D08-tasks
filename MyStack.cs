using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace taskD08
{
  
    public class MyStack<T> 
    {
        #region Data Fields
        T[] arr;
        int tos;
        int size;
        #endregion
 
        #region ctors
        public MyStack()
        {
            tos = 0;
            size = 5;
            arr = new T[size];
        }
        public MyStack(int _size)
        {
            tos = 0;
            size = _size;
            arr = new T[size];
        }
        #endregion
        #region Stack Functions
        public void Push(T value)
        {
          
            if (!IsFull())
            {
                arr[tos] = value;
                this.tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!");
            }
        }

        public T Pop()
        {
            T result = default;
            //if (tos != 0)
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
                
            }
            else
            {
                Console.WriteLine("EMPTY!!!!");
                //return -1234;
                ////Effective way -> throw runtime error
            }
            return result;
        }

        public bool IsFull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
        public T Peak()
        {
            return arr[tos - 1];
        }
        #endregion
    }

}
