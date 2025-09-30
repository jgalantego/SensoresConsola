# SensoresConsola

## Descripción
`SensoresConsola` es un programa de consola en C# que permite almacenar y procesar medidas de diferentes sensores utilizando **arrays jagged (`int[][]`)**.

El programa genera de forma aleatoria las medidas de cada sensor según los datos introducidos por el usuario y ofrece un menú interactivo para visualizar y analizar las medidas.

---

## Funcionalidades
1. Generar un número variable de sensores.  
2. Para cada sensor, generar un número variable de medidas.  
3. Rellenar automáticamente las medidas de forma aleatoria (entre 0 y 100).  
4. Menú interactivo que permite al usuario:  
   - Mostrar todas las medidas de todos los sensores.  
   - Mostrar las medidas de un sensor específico.  
   - Mostrar la media de las medidas de un sensor específico.  
   - Mostrar la media de las medidas de todos los sensores.  
   - Salir del programa.  

---

## Tecnologías
- Lenguaje: C#  
- Plataforma: .NET 7+ (compatible con .NET Core)  
- Estructura de datos: Array jagged (`int[][]`)  

---

## Uso

1. Clona el repositorio: git clone https://github.com/tu-usuario/SensoresConsola.git
2. Abre la carpeta del proyecto en Visual Studio Code o Visual Studio.
3. Ejecuta el proyecto desde la terminal con: dotnet run
4. Sigue las instrucciones en pantalla:
  - Ingresa el número de sensores.
  - Ingresa el número de medidas por cada sensor.
  - Navega por el menú para visualizar y analizar los datos.

---

## Ejemplo de ejecución

```
Escriba el número de sensores: 3
Número de medidas del sensor 1: 4
Número de medidas del sensor 2: 3
Número de medidas del sensor 3: 5

--- Menú ---
1. Mostrar todas las medidas de todos los sensores.
2. Mostrar las medidas de un sensor.
3. Mostrar la media de las medidas de un sensor.
4. Mostrar la media de las medidas de todos los sensores.
5. Salir.
Seleccione una opción: 1

Sensor 1: 23 45 67 12
Sensor 2: 56 34 78
Sensor 3: 12 89 45 67 34
```

---

## Consideraciones
- La entrada del usuario está validada usando int.TryParse para evitar errores de formato.
- La generación de medidas es completamente aleatoria (valores de 0 a 100), lo que permite probar distintos escenarios sin necesidad de introducir todos los datos manualmente.
- El programa utiliza arrays jagged para permitir que cada sensor tenga un número diferente de medidas.
