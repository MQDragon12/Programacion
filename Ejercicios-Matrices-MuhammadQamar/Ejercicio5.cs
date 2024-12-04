/*static int[][] RellenaDentada()
  {
    int[][] jardin = new int[][]
    {
        new int [] {1,3,2,1},
        new int [] {4,4,2},
        new int [] {2,1,3,3,5},
        new int [] {3,2}
    };
    return jardin;
  }

  static void MuestraJardin(int[][] jardin)
  {
    Console.WriteLine("Jardín: ");
    foreach (int[] fila in jardin)
    {
      foreach (int n in fila)
      {
        Console.Write($"{n,-3}");
      }
      Console.Write("\n");
    }
  }

  static int[] CuentaFlores(int[][] jardin)
  {
    int[] colores = new int[5];
    Console.WriteLine("Flores por color: ");
    for (int i = 0; i < jardin.Length; i++)
    {
      for (int j = 0; j < jardin[i].Length; j++)
      {
        colores[jardin[i][j] - 1]++;
      }
    }
    for (int i = 0, j = 1; i < colores.Length; i++, j++)
    {
      Console.WriteLine($"Color {j}: {colores[i]} flores");
    }
    return colores;
  }


  static void MuestraArrieteDiverso(int[,] cuentacolor)
  {
    int coloresDistintos = 0, numeroarriete = 0;
    for (int i = 0; i < cuentacolor.GetLength(0); i++)
    {
      int numerocolores = 0;
      for (int j = 0; j < cuentacolor.GetLength(1); j++)
      {
        if (cuentacolor[i, j] != 0)
        {
          numerocolores++;
        }
      }

      if (numerocolores > coloresDistintos)
      {
        coloresDistintos = numerocolores;
        numeroarriete = i;
      }
    }
    Console.WriteLine($"Arriate más diverso: Arriate {numeroarriete} con {coloresDistintos} colores distintos.");
  }
  static int[,] ArrieteDiverso(int[][] jardin, int[] colores)
  {
    int[,] cuentacolor = new int[jardin.Length, 5];
    for (int i = 0; i < jardin.Length; i++)
    {
      for (int j = 0; j < jardin[i].Length; j++)
      {
        int elemento = jardin[i][j] - 1;
        cuentacolor[i, elemento]++;
      }
    }
    return cuentacolor;
  }

  static void Main()
  {
    int[][] jardin = RellenaDentada();
    MuestraJardin(jardin);
    Console.WriteLine();
    int[] colores = CuentaFlores(jardin);
    Console.WriteLine();
    int[,] cuentacolor = ArrieteDiverso(jardin,colores);
    MuestraArrieteDiverso(cuentacolor);
    Console.ReadLine();
  }*/