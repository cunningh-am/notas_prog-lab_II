# Objetos

Una clase define un tipo de objeto, pero no es un objeto en sí. Un objeto es una entidad concreta basada en una clase y, a veces, se conoce como una instancia de una clase. Una instancia es una **manifestacion concreta** de algo. Poseen **comportamiento (metodos)**
y **estado (atributos)**. Para crear un objeto se utiliza la palabra reservada ***new*** seguido del nombre de la clase en la que se basará el objeto.
Los objetos son tipos de referencia que se almacenan en el ***Heap***

```
NombreClase nombreObjeto = new NombreClase();
```

## Ejemplo

```
public class Persona 
{
  public string nombre;
  public int edad;
  
  public Persona(string nombre, int edad)
  {
    this.nombre = nombre;
    this.edad = edad;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Persona personaUno = new Persona("Jose", 50);
    
    personaUno.nombre = "Manuel";
    personaUno.edad = 28;
  }
}
```

## Ciclo de vida de un objeto

1. Creacion del objeto  
    * Se usa ***new*** para asignar memoria.
    * Se usa un ***constructor*** para inicializar un objeto en esa memoria.
    
2. Utilizacion del objeto
    * Llamadas a metodos y atributos
    
3. Destruccion del objeto
    * Se pierde la referencia en memoria, ya sea por finalizacion del programa, cambio 
      o eliminacion de la variable, etc.
    * El ***Garbage Collector*** liberara memoria cuando lo crea.
    
## Constructores

| de instancia | estatico |
|:------------:|:--------:|
| Inicializan objetos | Inicializan clases          |


    
