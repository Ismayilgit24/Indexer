using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
	internal class ListInt
	{
		private int[] _arr;
		public int this[int index]
		{
			get
			{
				return _arr[index];
			}
			set
			{
				_arr[index] = value;
			}
		}
		public ListInt()
		{
			_arr = new int[0];
		}

		public ListInt(int length)
		{
			_arr = new int[length];
		}

		public void Add(int num)
		{
			
				Array.Resize(ref _arr, _arr.Length + 1);
				_arr[_arr.Length - 1] = num;
				Console.WriteLine(num);
			
		}

		public void AddRange(params int[] nums)
		{
			
			Array.Resize(ref _arr, _arr.Length + nums.Length);

			for(int i=0; i<nums.Length; i++)
			{
				_arr[_arr.Length - nums.Length + i] = nums[i];
				Console.WriteLine(_arr[i]);
			}
			
		}

		public bool Contains(int num)
		{
			for(int i=0; i<_arr.Length; i++)
			{
				if (num == _arr[i])
				{
					Console.WriteLine(true);
					return true;
                    
				}
				
			}
            Console.WriteLine(false);
			return false;
		}

		public void Sum()
		{
			int sum = 0;

			for(int i=0; i<_arr.Length; i++)
			{
				sum += _arr[i];

			}
            Console.WriteLine(sum);
		}

		public void Remove(int num)
		{
			int j = 0;
			int[] newArr = new int[_arr.Length - 1];

			for (int i=0; i<_arr.Length; i++)
			{
				if(num != _arr[i])
				{
					newArr[j] = _arr[i];
					j++;
				}
			}
			_arr = newArr; 
			for (int i=0; i<_arr.Length; i++)
			{
				Console.WriteLine(_arr[i]);
			}
		}

		

		public void RemoveRange(params int[] nums)
		{
			
			int[] newArr = new int[_arr.Length - nums.Length];
			int j = 0;

			for (int i = 0; i < _arr.Length; i++)
			{
				bool shouldRemove = false;
				
				for (int k = 0; k < nums.Length; k++)
				{
					if (_arr[i] == nums[k])
					{
						shouldRemove = true;
						break; 
					}
				}

				
				if (!shouldRemove)
				{
					newArr[j] = _arr[i];
					j++;
				}
			}

			_arr = newArr;

			
			for (int i = 0; i < _arr.Length; i++)
			{
				Console.WriteLine(_arr[i]);
			}
		}

		public override string ToString()
		{
            Console.WriteLine(string.Join(", ", _arr));
			return string.Concat(", ", _arr);


		}

	}
}

