using System;

namespace Advanced.Generics
{
    /// <summary>
    /// 
    /// T: It refers to a Template or Type. The consumer of this class will define the type of data the List should store
    /// </summary>
    public class GenericList<T>
    {
        public void Add(T value)
        {
            
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    }

