### Clase 1 - 22-03
# Introduccion a C#

[Pagina de la materia](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/)

C# es un **lenguaje** de programacion **multiproposito** y de **tipado estatico**. Utiliza principalmente el paradigma de la **programacion orientada a objetos**. 
En cuanto a la administracion de la memoria, C# se apoya en el tiempo de ejecucion para realizar la administracion de memoria automatica. El ***CLR (Common Language Runtime)*** tiene un ***Garbage Collector*** que ejecuta como parte del programa, que libera la memoria de los objetos que dejan de estar referenciados.

### Primer programa - "Hello World!"

```
namespace primerPrograma 
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            /* 
            Llamada al metodo WriteLine que se encuentra
            en la clase Console, definida en el namespace System
            */
        }
    }
}
```

* **namespace:** Tiene que representar algo significativo para el programa, con un nombre único. Cada Namespace puede tener diferentes clases, tantas como requiera el programa.
* **clases:** Las clases son plantillas para crear entidades, tantas como se requiera. Cada clase puede tener diferentes métodos.
* **metodos:** La forma o manera de ejecutar funcionalidades del programa.

### Common Type System (CTS)

Define un conjunto de tipos de datos común a todos los lenguajes soportados por .NET. 
   * Establece un marco de herramientas que habilita la ejecución de los distintos lenguajes de la plataforma.
   * Provee un modelo orientado a objetos.
   * Define un conjunto de reglas que todos los lenguajes deben seguir en lo que refiere a tipos.
   * Provee una biblioteca que contiene los tipos primitivos básicos (Boolean, Int32, Byte, Char, etc).
   * Define tipos de dato en dos categorías: de valor y de referencia.

### Tipos de datos

Algunas de las palabras clave de C# como `double`, `int` o `string` son ***alias (aliases)*** que representan tipos proveidos por la implementación de la plataforma .NET donde se ejecuta C#. Por ejemplo, `int` es un alias para el tipo `System.Int32`.

* Las variables **escalares** son constantes o variables que contienen un dato atomico y unidemensional.
* Las variables **no escalares** son arrays y objetos, que pueden tener almacenados mas de un valor.

### Valores predeterminados de los atributos de una clase

* Enteros - 0
* Flotante - 0
* Logicos - false
* Referencias - null

### Conversiones basicas

* **implicitas**: No interviene el programador y no deberían implicar pérdida de datos.
`float flotante = 15;`
* **Explicitas**: Interviene el programador y podrían implicar pérdida de datos.
`int entero = (int)15.2;`

### Operadores aritmeticos y logicos
Los operadores aritmeticos son iguales que en C. En cuanto a los operadores logicos, al hacer comparaciones todas las evaluaciones se hacen por cortocircuito.

### Sentencias repetitivas
Se agrega la sentencia **foreach:**  
```
string[] nombres = new string[5];

foreach (string auxNombre in nombres) {
  //auxNombre es un elemento de nombres.
}
```

### Entry Point de una aplicacion de consola

El **punto de entrada** para los programas en C# es la funcion **Main**

```
class HolaMundo
{
    static void Main(string[] args) 
    {
        System.Console.WriteLine("Hola mundo C#");
        System.Console.ReadKey();
    }
}
```

### Console

* Es una clase publica y estatica.
* Representa la entrada, salida y errores de Streams para aplicaciones de consola.
* Es miembo del NameSpace System.

### Formato de salida de texto

Formula general: `{N[,M][:Formato]}`  
> *[ ] -> uso opcional*

* **N:** Numero del parametro, empezando por cero.
* **M:** Ancho usado para mostrar el parametro, el cual se rellena de espacios. Si M es negativo, se justifica a la izquierda, y si es positivo, a la derecha.
* **Formato:** Cadena que indica el formato extra a usar con ese parametro.  

```
Console.WriteLine("{0,10}{1,-10}{2}", 10, 15, 23);
// Output:
//           1015          23
Console.WriteLine("{0,10:#,###.00}{1,10}", 10.476, 15.355);
// Output:
//           10.48          15.355
```

[Documentacion Microsoft - Formatos compuestos](https://docs.microsoft.com/es-es/dotnet/standard/base-types/composite-formatting)

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
