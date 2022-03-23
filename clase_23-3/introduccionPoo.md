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

![Ejemplo de Clase](https://www.campusmvp.es/recursos/image.axd?picture=/2019/4T/poo-clase-objetos.png)

## Creando una clase

```
[modificador] class Identificador 
{
  // miembros: atributos y metodos
}
```

* **modificador:** Determina la accesibilidad que tendras sobre ella otras clases.

   * **public:** Accesible desde cualquier proyecto.
   * **private:** Accesor por defecto.
   * **abstract:** Indica que la clase no podra instanciarse.
   * **internal:** Accesible en todo el proyecto.
   * **sealed:** Indica que la clase no podra heredar.

* **class:** Palabra reservada del lenguaje que indica que el codigo a continuacion es una clase.

* **Identificador:** Nombre de la clase. Siempre comienza con mayuscula y es un sustantivo.

### Atributos

```
[modificador] tipo identificador
```

**modificador:**
  * **private(*)**: Los miembros de la misma clase
  * **protected:** Miembros de la misma clase y clases hijas
  * **internal:** 
  * **internal protected**
  * **public**


### Metodos

Funciones dentro de una clase

```
[modificador] retorno Identificador ([args]) 
{
  // sentencias
}
```

**Identificador:** verbo y primera letra en mayuscula.

## Ejemplo de clase

```
public class Auto
{
  public Single velocidad;
  public static Byte cantidadRuedas;
  public static void TocarBocina() 
  {
    Console.Write("PiPi!");
  }
  public void Acelerar(Single velocidad) 
  {
    
  }
}
```
