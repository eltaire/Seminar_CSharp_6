double[,] elements = new double[2, 2];
double[] xPoint = new double[2];

void InputElements()
{
  for (int i = 0; i < elements.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b) \n");
    for (int j = 0; j < elements.GetLength(1); j++)
    {
      if(j==0) Console.Write($"введите коэффициент k: ");
      else Console.Write($"введите коэффициент b: ");
      elements[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Calculation(double[,] el)
{
  xPoint[0] = (el[1,1] - el[0,1]) / (el[0,0] - el[1,0]);
  xPoint[1] = xPoint[0] * el[0,0] + el[0,1];
  return xPoint;
}

void OutputResponse(double[,] el)
{
  if (el[0,0] == el[1,0] && el[0,1] == el[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (el[0,0] == el[1,0] && el[0,1] != el[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Calculation(el);
    Console.Write($"\nТочка пересечения прямых: ({xPoint[0]}, {xPoint[1]})");
  }
}

InputElements();
OutputResponse(elements);
