/*В прошлом примере мы указывали значение массива вручную. А сейчас перепишем этот код с
использованием генератора псевдослучайных чисел с использованием методов. Мы
потренируем то, каким образом можно взять, например, метод, передать в него массив и
заполнить массив нужным количеством элементов. На следующем этапе опишем метод,
который будет выводить все элементы по порядку. Затем превратим наш код поиска нужного
индекса в метод*/

void FillArray(int[] collection)    

{
    int Length = collection.Length;
    int index = 0;
    

       while (index < Length )
    {
    collection[index] = new Random().Next(1,10); 
    index++;
    }
      int[] array = new int[10]; 
}

       void PrintArray(int[] col)

       
{  

    int count = col.Length;
    int position = 0;
    while (position < count) 
    {
         Console.WriteLine(col[position]);
         position++;
    }
}

int IndexOf(int[] collection, int find)


{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
          position = index;
          break;
        }  
        
         index++;
    }     
        
        return position;
    

}
int[] array = new int[10];

FillArray(array);
array[4]= 4;
array[6]= 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,444 );
Console.WriteLine( pos);

