using System;
using System.Collections;
using System.Collections.Generic;

namespace laba6
{
	public class ListEnum<T> : IEnumerator<T>
    {
		private T[] list;
		int position = -1;

		public ListEnum(T[] list)
		{
			this.list = list;
		}

		public T Current 
		{
			get
			{
				try
				{
					return list[position];
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
			}
		}

		object IEnumerator.Current 
		{
			get
			{
				return Current;
			}
		}
                       

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			position++;
			return (position < list.Length);
		}

		public void Reset()
		{
			position = -1;
		}
	}
}
