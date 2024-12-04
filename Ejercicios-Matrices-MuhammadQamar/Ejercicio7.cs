/*static int[,] RellenaMatriz()
  {
    int[,] p = new int[3, 3];
    for (int i = 0; i < p.GetLength(0); i++)
    {
      for (int j = 0; j < p.GetLength(1); j++)
      {
        p[i, j] = 200;
        if (j == 1)
        {
          p[i, j] = 150;
        }
        if (j == 2)
        {
          p[i, j] = 125;
        }
      }
    }
    return p;
  }

  static void MuestraMatriz(int[,] p)
  {
    Console.WriteLine("       Sesion1   Sesion2   Sesion3");
    for (int i = 0; i < p.GetLength(0); i++)
    {
      if(i==0)
      {
      Console.Write("Sala A   ");
      }
      if(i==1)
      {
      Console.Write("Sala B   ");
      }
      if(i==2)
      {
      Console.Write("Sala C   ");
      }
      for (int j = 0; j < p.GetLength(1); j++)
      {
        Console.Write($"{p[i, j],-10}");
      }
      Console.Write("\n");
    }
  }

  static void MuestraOpcionesVenta(int[,] p)
  {
    Console.WriteLine("Introduce el número de entradas que deseas comprar: ");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduce la sala a la que deseas asistir (A,B,C): ");
    char sala = char.Parse(Console.ReadLine());
    sala = char.ToUpper(sala);
    Console.WriteLine("Introduce la sesión a la que deseas asistir (1,2,3): ");
    int sesion = int.Parse(Console.ReadLine()) - 1;
    int numerosala = 0;
    switch (sala)
    {
      case 'A':
        numerosala = 0;
        break;
      case 'B':
        numerosala = 1;
        break;
      case 'C':
        numerosala = 2;
        break;
    }

    if (p[sesion, numerosala] - numero > 0)
    {
      p[sesion, numerosala] = p[sesion, numerosala] - numero;
    }

    else
    {
      Console.WriteLine("No quedan suficientes entradas");
    }
  
  }

  static void MuestraMenu(int[,] p)
  {
    Console.WriteLine("1. Venta de entradas");
    Console.WriteLine("2. Estadística de aforo");
    Console.WriteLine("Introduce una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
      case 1:
        MuestraOpcionesVenta(p);
        break;
      case 2:
        MuestraMatriz(p);
        break;
    }
  }

  static void Main()
  {
    ConsoleKeyInfo salir = new ConsoleKeyInfo();
    bool esESC; 
     int[,] p = RellenaMatriz();
    do{
     
      MuestraMenu(p);
      salir=Console.ReadKey();
      esESC= salir.Key == ConsoleKey.Escape;
    }while(esESC==false);

  }*/