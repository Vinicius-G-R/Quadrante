double x, y;
    Console.Clear();
    Console.WriteLine("--- Quadrante Cartesiano ---\n");
    Console.WriteLine("Entre com o ponto desejado.");
    Console.Write("Coordenada x: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Coordenada y: ");
    y = Convert.ToDouble(Console.ReadLine());
     
    Console.Write($"\nO ponto ({x}, {y}) fica ");

    if (x > 0 && y > 0) 
    Console.WriteLine("no quadrante 1");
    
    else if (x < 0 && y > 0)
    Console.WriteLine("no quadrante 2");
        
    else if (x < 0 && y < 0)
    Console.WriteLine("no quadrante 3");

    else if (x > 0 && y < 0)
    Console.WriteLine("no quadrante 4");
    
    else if (x == 0 && y != 0)
    Console.WriteLine("no eixo das ordenadas.");
    
    else if (x != 0 && y == 0)
    Console.WriteLine("no eixo das abscissas.");
      
    else 
    Console.WriteLine("no ponto de origem");
