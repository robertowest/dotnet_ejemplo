# Ejemplo simple

En este fragmento de código, crearemos una nueva solución y dos proyectos. Un proyecto de librería y otro de consola. Agregaremos ambos proyectos a la solución y ejecutaremos el proyecto de consola.

El proyecto es algo muy simple, una clase que determina si la palabra ingresada comienza con una letra mayúscula y un proyecto de consola para ejecutarlo.

```bash
mkdir /tmp/ejemplo
cd /tmp/ejemplo
dotnet new sln
dotnet new classlib -o StringLibrary
dotnet new console -o ShowCase
dotnet sln add StringLibrary/StringLibrary.csproj
dotnet sln add ShowCase/ShowCase.csproj
dotnet build
dotnet run --project ShowCase/ShowCase.csproj
```
