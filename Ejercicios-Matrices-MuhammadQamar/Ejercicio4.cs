/*static int[][] RellenaDentada()
  {
    int[][] m = new int[][]
    {
      new int [] {1,2,3,4},
      new int [] {5,6,7},
      new int [] {9,10,11,12,5},
      new int [] {9,10}
    };
    return m;
  }

  static int BuscaMayor(int[][] m)
  {
    int c=0;
    int maximo = int.MinValue;
    foreach (int[] fila in m)
    {
      foreach (int numero in fila)
      {
          c++;
          if(c>maximo)
          {
              maximo=c;
          }
      }
      c=0;
    }
    return maximo;
  }

static void MuestraDentada(int[][] m, int maximo)
{
  foreach (int[] fila in m)
    {
      if(fila.Length == maximo)
      {
        foreach(int num in fila)
        {
          Console.Write($"{num,-4}");
        }
      }
  }
}
  static void Main()
  {
    int[][] m = RellenaDentada();
    int maximo = BuscaMayor(m);
    MuestraDentada(m,maximo);
    Console.ReadLine();
  }*/
