Console.WriteLine("Введите число элементов Вашего массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[n];
void FillMassiv(int n)
     {
        int i = 0;
       while (i < n)
        {
           Console.WriteLine("Введите элемент массива");
           Massiv[i] = Convert.ToInt32(Console.ReadLine());
           i++;
        }
   }
int Comparison(int[] Massiv)
    {   
        int count = 0;
        for (int i = 0; i < Massiv.Length; i++)
        {
            if(Massiv[i] > 0 ) count += 1; 
        }
    return count;
}

FillMassiv(n);

Console.WriteLine($"Количество чисел в Вашем массиве, которые больше 0, равно {Comparison(Massiv)}. ");
