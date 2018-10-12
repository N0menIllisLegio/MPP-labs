using System.Collections.Generic;
using System;
using System.Collections;

namespace laba6
{
	public class DynamicList<T> : IEnumerable<T>
	{
		private T[] list;

		public int Count 
		{
			get
			{            
				return list == null ? 0 : list.Length;	
			} 
		}

		public T this[int index]
		{
			get
			{
				return list[index];
			}
			set
			{
				list[index] = value;
			}
		}
              
		public DynamicList(T[] list)
		{
			this.list = new T[list.Length];
			int i = 0;
			foreach (var element in list)
			{
				this.list[i++] = element;
			}
		}

		public DynamicList()
		{
			list = new T[0];
		}

        public void Add(T item)
		{
			Array.Resize(ref list, list.Length + 1);
			list[list.Length - 1] = item;
		}
        
		public void Remove(T item)
		{
			T[] tempList = list;
			T[] newList = new T[list.Length - 1];
           
				
			bool itemDeleted = false;
			int j = 0;
                     
			for (int i = 0; i < tempList.Length; i++)
			{
				if (list[i].Equals(item) && !itemDeleted)
                {
					itemDeleted = true;
                }
				else
				{
					if (j < newList.Length - 1)
					{
						newList[j++] = tempList[i];
					}

				}
			}

			if (itemDeleted)
			{
				list = tempList;
			}
		}
        
        public void RemoveAt(int index)
		{
			if (index < 0 || index > list.Length - 1)
			{
				return;
			}

			T[] newList = new T[list.Length - 1];
			int j = 0;

			for (int i = 0; i < list.Length; i++)
            {
				if (i != index)
                {
					newList[j++] = list[i];
                }            
            }

			list = newList;
		}

        public void Clear()
		{
			list = new T[0];
		}
        
     

		public ListEnum<T> GetEnumerator()
		{
			return new ListEnum<T>(list);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator) GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return ((IEnumerable<T>)list).GetEnumerator();
		}
	}

    

}