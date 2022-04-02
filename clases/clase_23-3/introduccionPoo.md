### Clase 2 - 23-03
# Introduccion POO

Un **paradigma** suminista la base y modelo para resolver problemas y avanzar en el conocimiento. Un **paradigma de programacion** define la forma, metodologia o estilo con el que se resolvera un problema utilizando un lenguaje de programacion.  
El **paradigma de la programacion orientada a objetos** propoen resolver problemas a traves de la identificacion de objetos en la vida real, sus **atributos**, su **comportamiento** y las relaciones de colaboracion entre ellos.

## Pilares

#### 1. Abstraccion  

Ignorar selectivamente algo. **Ignorar detalles de un elemento y enfocarme en lo importante**. Nos permite obtener una vista mas simple de algo complejo, definiendo distintos niveles de detalle.
 
#### 2. Encapsulamiento  

Define el alcance y la visibilidad de un miembro de una clase. Se usan **modificadores de acceso...**  

#### 3. Herencia  

Establece una relacion padre-hijo entre dos clases, de tal forma que el hijo hereda las propiedades y metodos del padre.

#### 4. Polimorfismo  

La definicion del metodo reside en la clase padre. Su implementacion, en la clase hija.

## Clases

Una clase es una **implementacion de una abstraccion**. Describe un conjunto de objetos que comparten comportamientos, atributos, relaciones y semantica.

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
class Auto // por defecto internal
{
  private float velocidad;
  private string color;

  public void AsignaVelocidad(float velocidad) 
  {
    this.velocidad = velocidad;
  }
  
  public void TocarBocina();
  {
    Console.WriteLine("PiPi!");
  }
}
```

### Codigo de la clase

[Program.cs (Main)](https://github.com/valentinbegnis/notas_prog-lab_II/blob/main/clases/clase_23-3/Program.cs)  

[Sello.cs (Clase)](https://github.com/valentinbegnis/notas_prog-lab_II/blob/main/clases/clase_23-3/Sello.cs)
