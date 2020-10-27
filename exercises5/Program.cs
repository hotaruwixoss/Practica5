using System;

namespace exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEjercicio 1:");
            /*Preguntar al usuario su edad, que se guardará en un "byte". A continuación,
              se deberá le deberá decir que no aparenta tantos años (por ejemplo, "No
              aparentas 20 años").*/


            Console.WriteLine("Digita tu edad: ");
            byte edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas de " + edad + " años");

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 2:");

            /*Pedir al usuario dos números enteros largos ("long") y mostrar su suma, su
              resta y su producto.*/

            Console.WriteLine("\nDigita el primer número largo: ");
            long num1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Digita el primer número largo: ");
            long num2 = long.Parse(Console.ReadLine());

            Console.WriteLine("\nEste es la suma de los números digitados: " + (num1 + num2));
            Console.WriteLine("\nEste es la resta de los números digitados: " + (num1 - num2));
            Console.WriteLine("\nEste es el producto de los números digitados: " + (num1 * num2));

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 3:");

            /*Crear un programa que use tres variables x,y,z. Sus valores iniciales serán
              15, -10, 2.147.483.647. Se deberá incrementar tres veces el valor de estas
              variables. Mostrar en pantalla el valor incial de las variables y el valor final
              obtenido por el programa.*/

            int x = 15; int y = -10;

            x *= 3; y *= -10;

            Console.WriteLine("\nEl valor inicial de x es 15 y el valor final es: " + x);

            Console.WriteLine("\nEl valor inicial de y es -10 y el valor final es: " + y);

            long z = 2147483647;

            z *= 3;

            Console.WriteLine("\nEl valor inicial de x es 2.147.483.647 y el valor final es: " + z);

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 4:\n");

            /*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++;
              b=b*5; a=a*2;*/


            int a = 5;
            int b = ++a;

            Console.WriteLine("\nLos resultados de la primera operación b = ++a, sabiendo que a es 5, es " + b);

            int c = a++;
            Console.WriteLine("\nLos resultados de la segunda operación c = a++, es " + c);

            b *= 5;
            Console.WriteLine("\nLos resultados de la tercera operación de b = b * 5, es " + b);

            a *= 2;
            Console.WriteLine("\nLos resultados de la cuarta operación  a = a * 2, es " + a);

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 5:\n");

            /*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3;
              c=-3; c*=2; ++c; a*=b;*/

            a = 5;
            b = a + 2;

            Console.WriteLine("\nLos resultados de la operación b = a + 2, es " + b);

            b -= 3;
            Console.WriteLine("\nLos resultados de la operación b -= 3, es " + b);

            c = -3;
            Console.WriteLine("\nLos resultados de la operación c = -3, es " + c);

            c *= 2;
            Console.WriteLine("\nLos resultados de la operación c *= 2, es " + c);

            c = ++c;
            Console.WriteLine("\nLos resultados de la operación c = ++c, es " + c);

            a *= b;
            Console.WriteLine("\nLos resultados de la operación a *= b, es " + a);

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 6:\n");

            /*Calcular el área de un círculo, dado su radio (pi * radio al cuadrado).*/

            Console.WriteLine("Digita un numero para usarlo como radio: ");
            int radio = Convert.ToInt32(Console.ReadLine());

            var circle = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El área de un circulo, dado el radio que digitaste es: " + circle);

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 7:\n");

            /*Crear un programa que pida al usuario a una distancia (en metros) y el
            tiempo necesario para recorrerla (como tres números: horas, minutos,
            segundos), y muestre la velocidad, en metros por segundo, en kilómetros
            por hora y en millas por hora (pista: 1 milla = 1.609 metros).*/

            Console.WriteLine("Digite una distancia en metros: ");
            int metros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el tiempo necesario para recorrela en horas: ");
            int horas = Convert.ToInt16(Console.ReadLine());

            int minutos = horas * 60;
            Console.WriteLine("En minutos el tiempo es: " + minutos);

            int segundos = minutos * 60;
            Console.WriteLine("\nEn segundos el tiempo es: " + segundos);

            double velocidad = metros / horas;
            Console.WriteLine("La velocidad es " + velocidad + " m/s");

            double km = metros / 1000;
            Console.WriteLine("En Kilometros por hora la velocidad es de: " + km + " m");

            double millas = km * 0.62137;
            Console.WriteLine("En millas por hora la velocidad es de: " + millas + " mi");

            Console.ReadKey();

        }
    }
}
