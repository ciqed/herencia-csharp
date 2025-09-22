# Ejemplo de Herencia en C#

Este proyecto es un programa de consola en **C#** que demuestra el uso de **herencia y polimorfismo** con un gestor de vehículos.

## Clases

- `Vehiculo` → Clase base con propiedades comunes (`Marca`, `Modelo`, `Año`).
- `Auto` → Clase derivada que hereda de `Vehiculo` y agrega `NumPuertas`.
- `Moto` → Clase derivada que hereda de `Vehiculo` y agrega `Cilindrada`.

## Código principal

```csharp
Auto coche1 = new Auto { Marca = "Toyota", Modelo = "Corolla", Año = 2020, NumPuertas = 4 };
coche1.MostrarInfo();

Moto moto1 = new Moto { Marca = "Yamaha", Modelo = "R1", Año = 2022, Cilindrada = 1000 };
moto1.MostrarInfo();
