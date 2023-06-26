using System;

    class AreaDaForma{
        public int l1;
        public int l2;
        public double B;
        public double h;
        public double A;
        
        public int area(int l1, int l2){
            return l1 * l2;
        }
        public double area(double B, double h){
           return (B * h)/2;
        }
    }

class calcArea {
  static void Main() {
      AreaDaForma a = new AreaDaForma();
      int opc;
    Console.WriteLine("Qual poligono você quer saber a área");
    Console.WriteLine("1-Quadrado/2-Retangulo/3-Triangulo");
    opc = Convert.ToInt32(Console.ReadLine());
    switch (opc)
    {
        case 1: Console.WriteLine("Digite o valor do lado 1: ");
        a.l1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do lado 2: ");
        a.l2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a.area(a.l1, a.l2));
        break;
        
        case 2: Console.WriteLine("Digite o valor do lado 1: ");
        a.l1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do lado 2: ");
        a.l2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a.area(a.l1, a.l2));
        break;
        
        case 3: Console.WriteLine("Digite o valor da base: ");
        a.B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura: ");
        a.h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a.area(a.B, a.h));
        break;
    }
  }
}