using ArbolB;
using System;

namespace ArbolRamas
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 Arbol Binario");
                Console.WriteLine("2 Arbol Multiples Hijos");
                Console.WriteLine("3 Contar Niveles del arbol binario");
                Console.WriteLine("4 Contar Hojas del arbol binario");
                Console.WriteLine(" 5 Contar Nodos totales del arbol");
                Console.WriteLine(" 6 Navegación Horizontal a traves del arbol");
                Console.WriteLine(" 7 Expresiones matemática con suma, resta, multiplicacion y division");
                Console.WriteLine(" 8 Exit");
                Console.WriteLine(" Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Crear Arbol Cinario");
                        Program.construirArbolB();
                        Console.WriteLine(" Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(" Crear Arbol multiples Hijos");
                        Program.construirArbolVariosHijos();
                        Console.WriteLine("  Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Contador de niveles Arbol Mutiples Hijos");
                        Program.contarNiveles();
                        Console.WriteLine("  Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine(" Contardor de hojas Arbol Mutiples Hijos");
                        Program.contarHojas();
                        Console.WriteLine("  Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine(" Contar nodos Arbol Mutiples Hijos");
                        Program.contarNodos();
                        Console.WriteLine("  Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine(" programa horizontal POSTORDEN");
                        Program.NavegarHorizontalmente();
                        Console.WriteLine("  Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine(" Operacion mediante expresión matematica");
                        Program.OperarExpresion();
                        Console.WriteLine(" Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine(" Presiona una tecla para continuar");
                        Console.ReadLine();
                        opcion = 8;
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 8);


        }
        public static void construirArbolB()
        {
            var raiz = new Nodo("*",
           new Nodo("2",
               new Nodo("2.2",
                   new Nodo("2.2.2"),
                   new Nodo("2.2.3")),
               new Nodo("2.3",
                   new Nodo("2.3.2"),
                   new Nodo("2.3.3"))),
           new Nodo("4",
               new Nodo("4.3",
                   new Nodo("3.2.2"),
                   new Nodo("4.2.3")),
               new Nodo("3.3",
                   new Nodo("3.3.2"),
                   new Nodo("3.3.3"))));


            Administrador admin = new Administrador();
            admin.RecorrerArbol(raiz);
        }
        public static void construirArbolVariosHijos()
        {
            NodoExt nodoA1 = new NodoExt("A1");
            NodoExt nodoB2 = new NodoExt("B2");
            NodoExt nodoC3 = new NodoExt("C3");
            NodoExt nodoD4 = new NodoExt("D4");
            NodoExt nodoE5 = new NodoExt("E5");
            NodoExt nodoF6 = new NodoExt("F6");
            NodoExt nodoG7 = new NodoExt("G7");

            //Raiz
            nodoA1.Hijos.Add(nodoB2);
            nodoA1.Hijos.Add(nodoC3);

            //
            nodoB2.Hijos.Add(nodoD4);
            nodoB2.Hijos.Add(nodoE5);
            //
            nodoC3.Hijos.Add(nodoF6);
            nodoC3.Hijos.Add(nodoG7);
            //
            nodoD4.Hijos.Add(new NodoExt("H8"));
            nodoD4.Hijos.Add(new NodoExt("I9"));
            nodoE5.Hijos.Add(new NodoExt("J10"));
            nodoE5.Hijos.Add(new NodoExt("K11"));

            nodoF6.Hijos.Add(new NodoExt("L12"));
            nodoF6.Hijos.Add(new NodoExt("M13"));
            nodoG7.Hijos.Add(new NodoExt("N14"));
            nodoG7.Hijos.Add(new NodoExt("Ñ15"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA1);
        }
        public static void contarNiveles()
        {
            NodoExt nodoA1 = new NodoExt("A1");
            NodoExt nodoB2 = new NodoExt("B2");
            NodoExt nodoC3 = new NodoExt("C3");
            NodoExt nodoD4 = new NodoExt("D4");
            NodoExt nodoE5 = new NodoExt("E5");
            NodoExt nodoF6 = new NodoExt("F6");
            NodoExt nodoG7 = new NodoExt("G7");

            NodoExt nodoJ10 = new NodoExt("J10");
            NodoExt nodoK11 = new NodoExt("K11");

            
            nodoA1.Hijos.Add(nodoB2);
            nodoA1.Hijos.Add(nodoC3);

            nodoB2.Hijos.Add(nodoD4);
            nodoB2.Hijos.Add(nodoE5);
           
            nodoC3.Hijos.Add(nodoF6);
            nodoC3.Hijos.Add(nodoG7);
           
            nodoD4.Hijos.Add(new NodoExt("L12"));
            nodoD4.Hijos.Add(new NodoExt("M13"));
            
            nodoE5.Hijos.Add(new NodoExt("N14"));
            nodoE5.Hijos.Add(new NodoExt("Ñ15"));
           
            nodoF6.Hijos.Add(new NodoExt("O16"));
            nodoF6.Hijos.Add(new NodoExt("P17"));
           
            nodoG7.Hijos.Add(nodoJ10);
            nodoG7.Hijos.Add(new NodoExt("18"));
          
            nodoJ10.Hijos.Add(nodoK11);

            NodoExt.ImprmirArbolMultiplesHijos(nodoA1);

            Console.WriteLine("EL ARBOL TIENE {0} NIVELES !!!", NodoExt.ContarNiveles(nodoA));
        }
        public static void contarHojas()
        {
            NodoExt nodoA1 = new NodoExt("A1");
            NodoExt nodoB2 = new NodoExt("B2");
            NodoExt nodoC3 = new NodoExt("C3");
            NodoExt nodoD4 = new NodoExt("D4");
            NodoExt nodoE5 = new NodoExt("E5");
            NodoExt nodoF6 = new NodoExt("F6");
            NodoExt nodoG7 = new NodoExt("G7");

            nodoA1.Hijos.Add(nodoB2);
            nodoA1.Hijos.Add(nodoC3);

            nodoB2.Hijos.Add(nodoD4);
            nodoB2.Hijos.Add(nodoE5);
            
            nodoC3.Hijos.Add(nodoF6);
            nodoC3.Hijos.Add(nodoG7);
            
            nodoD4.Hijos.Add(new NodoExt("L12"));
            nodoD4.Hijos.Add(new NodoExt("M13"));
            
            nodoE5.Hijos.Add(new NodoExt("N14"));
            nodoE5.Hijos.Add(new NodoExt("Ñ15"));
            
            nodoF6.Hijos.Add(new NodoExt("O16"));
            nodoF6.Hijos.Add(new NodoExt("P17"));
          
            nodoG7.Hijos.Add(new NodoExt("Q18"));
            

            NodoExt.ImprmirArbolMultiplesHijos(nodoA1);
            Console.WriteLine("El arbol binario tiene {0} HOJAS ", NodoExt.ContarHojas(nodoA1));

        }
        public static void contarNodos()
        {
            NodoExt nodoA1 = new NodoExt("A1");
            NodoExt nodoB2 = new NodoExt("B2");
            NodoExt nodoC3 = new NodoExt("C3");
            NodoExt nodoD4 = new NodoExt("D4");
            NodoExt nodoE5 = new NodoExt("E5");
            NodoExt nodoF6 = new NodoExt("F6");
            NodoExt nodoG7 = new NodoExt("G7");

            nodoA1.Hijos.Add(nodoB2);
            nodoA1.Hijos.Add(nodoC3);
            
            nodoB2.Hijos.Add(nodoD4);
            nodoB2.Hijos.Add(nodoE5);
           
            nodoC3.Hijos.Add(nodoF6);
            nodoC3.Hijos.Add(nodoG7);
            
            nodoD4.Hijos.Add(new NodoExt("L12"));
            nodoD4.Hijos.Add(new NodoExt("M13"));
            
            nodoE5.Hijos.Add(new NodoExt("N14"));
            nodoE5.Hijos.Add(new NodoExt("Ñ15"));
            
            nodoF6.Hijos.Add(new NodoExt("O16"));
            nodoF6.Hijos.Add(new NodoExt("P17"));
           
            nodoG7.Hijos.Add(new NodoExt("Q18"));
            NodoExt.ImprmirArbolMultiplesHijos(nodoA1);
            Console.WriteLine("el arbol tiene {0} NODOS", NodoExt.ContarNodos(nodoA1));
        }
        public static void NavegarHorizontalmente()
        {
            var raiz = new Nodo("*",
            new Nodo("2",
                new Nodo("2.2",
                    new Nodo("2.2.2"),
                    new Nodo("2.2.3")),
                new Nodo("2.3",
                    new Nodo("2.3.2"),
                    new Nodo("2.3.3"))),
            new Nodo("4",
                new Nodo("4.3",
                    new Nodo("3.2.2"),
                    new Nodo("4.2.3")),
                new Nodo("3.3",
                    new Nodo("3.3.2"),
                    new Nodo("3.3.3"))));


            Administrador admin = new Administrador();
            admin.NavegarHorizontal(raiz);
        }
        public static void OperarExpresion()
        {

            Administrador admin = new Administrador();

            //Crear arbol manual 
            var arbolOperaciones = new Nodo("+",
                new Nodo("9"),
                new Nodo("+",
                    new Nodo("7"),
                    new Nodo("+",
                        new Nodo("-7"),
                            new Nodo("8"))));
            Console.WriteLine("La suma total del arbol es " + admin.SumarArbol(arbolOperaciones));
            Console.WriteLine("\n");

            //Crear arbol apartir 
            Nodo nodoOperacion = new Nodo();
            admin.CrearArbol(nodoOperacion, "9+7+7+8");
            admin.RecorrerArbol(nodoOperacion);
           
        }
    }
}
