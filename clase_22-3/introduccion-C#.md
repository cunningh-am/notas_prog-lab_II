### Clase 1 - 22-03
# Introduccion a C#

[Pagina de la materia](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/)

> C# es un lenguaje derivado de C, la sintaxis es similar. Este lenguaje esta  pensado para resolver problemas mediante la aplicacion del paradigma de la   programacion orientada a objetos.

#### Common Type System (CTS)
* Define un conjunto comun de tipos de datos orientados a objetos.
* Todo lenguaje de programacion .NET debe implementar los tipos definidos por el CTS.
* Todo tipo hereda directa o indirectamente del tipo System.Object.
* El CTS define tipos de valor y referencia.

#### Tipos de datos
* Las variables **escalares** son constantes o variables que contienen un dato atomico y unidemensional.
* Las variables **no escalares** son arrays y objetos, que pueden tener almacenados mas de un valor.

#### Valores predeterminados (atributos de clase)
* Enteros - 0
* Flotante - 0
* Logicos - False
* Referencias - NULL

#### Conversiones basicas
* **implicitas**: No interviene el programador  
`float flotante = 15;`
* **Explicitas**: Interviene el programador, ya que puede haber perdida de datos  
`int entero = (int)15.2;`

#### Operadores aritmeticos y logicos
Los operadores aritmeticos son iguales que en C. En cuanto a los operadores logicos, al hacer comparaciones todas las evaluaciones se hacen por cortocircuito.

#### Sentencias repetitivas
Se agrega la sentencia **foreach:**  
```
string[] nombres = new string[5];

foreach (string auxNombre in nombres) {
  //auxNombre es un elemento de nombres.
}
```

### Entry Point de una aplicacion de consola

```
class HolaMundo {
  static void Main(string[] args) {
    System.Console.WriteLine("Hola mundo C#");
    System.Console.ReadKey();
  }
}
```

#### Console

* Es una clase publica y estatica.
* Representa la entrada, salida y errores de Streams para aplicaciones de consola.
* Es miembo del NameSpace System.

### Codigo de la clase
```
using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 edad = 18;
            String nombre = "Juan";

            Console.Title = "Ejercicio01"; // Titulo de la consola
            Console.WriteLine("Hello World!");
            // Imprimir en consola agregando secuencia de escape de salto de linea
            // equivalente a printf("Hello World!"); de C

            // Console.Write() -> Sin salto de linea

            Console.WriteLine("Nombre: {0} y edad: {1}", nombre, edad);

            Console.WriteLine("Ingrese apellido: ");
            String retorno = Console.ReadLine();  // Lee todo lo que escriba el usuario

            Console.WriteLine("Ingrese DNI: ");
            String dni_string = Console.ReadLine();

            int dni = int.Parse(dni_string); // Casteo explicito

            Console.Clear();
            Console.WriteLine("DNI: {3}\nAPELLIDO: {2}\nEDAD: {1} - NOMBRE: {0}", nombre, edad, retorno, dni);

            Console.ReadKey(); // Esperar a que se presione una tecla para cerrar la consola
        }
    }
}
```
