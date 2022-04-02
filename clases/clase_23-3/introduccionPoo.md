### Clase 2 - 23-03
# Introduccion POO
* Es una forma distinta de construir sofware. Otro paradigma.
* Propone resolver problemas mediante la identificacion de objetos y la relacion entre ellos. 
* El **Objeto** y el **Mensaje** son sus elementos fundamentales.

## Pilares

### 1. Abstraccion  

Ignorar selectivamente algo. Ignorar detalles de un elemento y enfocarme en lo importante. 
 
### 2. Encapsulamiento  

Define el alcance y la visibilidad de un miembro de una clase. Se usan **modificadores de acceso...**  

### 3. Herencia  

Establece una relacion padre-hijo entre dos clases, de tal forma que el hijo herede las propiedades y metodos del padre.

### 4. Polimorfismo  

La definicion del metodo reside en la clase padre. Su implementacion, reside en la clase hija.

## Clases

Es una abstraccion de un objeto. Defino comportamientos y atributos comunes a los objetos que se instanciaran de la misma.

<div align="center">
 <img width="487" height="400" src="https://www.campusmvp.es/recursos/image.axd?picture=/2019/4T/poo-clase-objetos.png"/>
</div>
 
## Creando una clase

```C#
[modificador] class Identificador 
{
  // miembros: atributos y metodos
  
  [modificador] tipo identificador // atributo
  
  [modificador] retorno Identificador([args]) // metodo
  {
   // Sentencias
  }
}
```
[comment]: <>    (| Modificador | Descripcion |)
[comment]: <>    (|:-----------|:-----------|)
[comment]: <>    (| `public`     | Accesible dentro del mismo proyecto  |)
[comment]: <>    (| `private`    | Accesible dentro de la misma clase   |)
[comment]: <>    (| `protected`  | Accesible dentro de la misma clase o en una clase derivada |)
[comment]: <>    (|  `internal ` | Accesible por codigo dentro de la misma compilacion |   )

## Modificadores
Un modificador determina la accesibilidad que tendra sobre un elemento otras clases.  
   
| **Ubicacion**                | `public` | `protected internal`  | `protected` | `internal` | `private protected` | `private` |
|:----------               |:--------:|:---------------------:|:-----------:|:----------:|:-------------------:|:---------:|
| Dentro de la misma clase | ✔ | ✔  | ✔  |  ✔   | ✔  | ✔  |
| Clase derivada (mismo proyecto) | ✔  | ✔  | ✔  | ✔  | ✔  | ❌  |
| Clase no derivada (mismo proyecto)  | ✔  | ✔  | ❌  | ✔  | ❌  | ❌  |
| Clase derivada (proyecto distinto) | ✔ | ✔  | ✔  | ❌  | ❌  | ❌  |
| Clase no derivada (proyecto distinto) | ✔  | ❌  | ❌  | ❌  | ❌  | ❌  |

> Para ver ejemplos de uso de cada modificador: [code-maze.com](https://code-maze.com/csharp-access-modifiers/)

## Ejemplo basico de una clase:

```C#
public class Auto
{
  public static int velocidad;

  public static void TocarBocina();
  {
    Console.WriteLine("PiPi!");
  }
}
```

### Codigo de la clase

[Program.cs (Main)](https://github.com/valentinbegnis/notas_prog-lab_II/blob/main/clases/clase_23-3/Program.cs)  

[Sello.cs (Clase)](https://github.com/valentinbegnis/notas_prog-lab_II/blob/main/clases/clase_23-3/Sello.cs)
