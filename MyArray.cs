using System;

class MyArray
{
	public int[] data;
	public int size;
	public int count;

	public MyArray(int size)
	{
		this.size = size;
		data = new int[size];
		count = 0;

	}
	public void Add(int item)
	{
		if (count == size)
			throw new Exception("Can't add because you already reached size limit");
		data[count] = item;
		count++;
	}

	public void Remove(int index)
	{
		if (count == 0)
		{
			throw new Exception("There is nothing delete");
		}
		else if (index > count - 1)
		{
			throw new IndexOutOfRangeException("index out of bound");
		}

		else if (index < count - 1)
		{
			for (int i = index; i < count - 1; i++)
			{

				data[i] = data[i + 1];
			}
		}
		count--;
	}
	public int Get(int index)
	{
		if (index >= size)
			throw new Exception("index does not exist because it is bigger than the size of the array");

		return data[index];


	}
	public void Print()
	{
		for (int i = 0; i < count; i++)
		{
			Console.Write(data[i] + ", ");

		}
		Console.WriteLine();
	}
	public void update(int index, int item)
	{
		if (index >= count)
			throw new IndexOutOfRangeException("index is out of bounds");
		else
		{
			data[index] = item;
		}
	}
}