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

Establece una relacion padre-hijo entre dos clases, de tal forma que el hijo herede las propiedades y metodos del padre. La herencia es simple.

### 4. Polimorfismo  

Van a existir metodos pertenecientes a una clase padre que al

## Clases

Es una abstraccion de un objeto. Defino comportamientos y atributos comunes a los objetos que se instanciaran de la misma.

<div align="center">
 <img src="https://www.campusmvp.es/recursos/image.axd?picture=/2019/4T/poo-clase-objetos.png"/>
</div>
 
## Creando una clase

```
[modificador] class Identificador 
{
  // miembros: atributos y metodos
}
```

* **modificador:** Determina la accesibilidad que tendran sobre ella otras clases.  


   | Modificador | Descripcion |
   |:-----------|:-----------|
   | `public`    | Codigo accesible para todas las clases                                    |
   | `private`   | Codigo accesible dentro de la misma clase                                 |
   | `protected` | Codigo accesible dentro de la misma clase o en una clase heredada de esta |
   |  `internal` | Codigo accesible por todo el proyecto                                     |

* **class:** Palabra reservada del lenguaje que indica que el codigo a continuacion es una clase.

* **Identificador:** Nombre de la clase. Siempre comienza con mayuscula y es un sustantivo.

```
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
