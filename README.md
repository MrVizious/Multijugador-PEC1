# PEC 1 - Juegos multijugador

Trabajo realizado por Javier Riera

# Elementos realizados

## Obligatorio

-Se ha realizado toda la tarea obligatoria. Se pueden incorporar los jugadores 3 y 4 en mitad de la partida y el juego seguirá funcionando.

- Se ha modificado la función que calcula si hay que hacer zoom para que tenga en cuenta todos los jugadores, no solo el 1 y el 2.
- Se ha creado un sistema rudimentario de guardado de datos entre niveles usando ScriptableObjects. De momento solo guarda el número de jugadores con los que empezar el juego, pero se podría configurar para añadir más datos.
- Cuando un jugador muere, su pantalla desaparece y el resto se redimensionan para no desaprovehar espacio.
- El layout de 3 jugadores divide la pantalla inderior en 2, colocando al 3er jugador abajo a la derecha. Si se añade un 4o jugador, este se colocará arriba a la derecha, para mantener las posiciones de las cámaras lo más estables posibles y no suponer un problema durante el juego.

## Opcional

### Minimapa

- El minimapa solo aparece cuando hay 3 jugadores a la vez. Usa una cámara ortográfica en lo alto apuntando hacia abajo que renderiza la escena entera. A la hora de ajustar los cambios de distribución de las pantallas, se decide si ha de mostrarse el minimapa o no.

### Menú de inicio sencillo

- Se ha añadido un menú de inicio con 3 botones con los que poder iniciar el juego: 2, 3 y 4 jugadores, para hacerlo muy sencillo de usar.

# Posibles errores

El juego se ha realizado en linux, y es conocido que el soporte de mandos es muy pobre en la versión Linux de Unity. Si hay algún tipo de error con el mapeado de botones, convendría modificar las asignaciones según lo que se sepa que funciona en el ordenador del usuario.
