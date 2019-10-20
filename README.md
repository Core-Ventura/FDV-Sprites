# FDV-Sprites

Actividades a realizar:

1) Obtener assets que incorpores a tu proyecto: Sprites individuales y Atlas de Sprites.
2) Incorporar los recursos del punto 1 en el proyecto y generar al menos 2 animaciones para uno de los personajes.
3) Busca en el inspector de objetos la propiedad Flip y comprueba qué pasa al activarla desactivarla en alguno de los ejes.
4) Mover uno de os personajes con el eje horizontal virtual que definen las teclas de flechas.
5) Crear una animación para otro personaje, que se active cuando el personaje esté a una distancia menor que un determinado umbral.

Para realizar la actividad he realizado una pequeña escena, en la que nos encontraremos al jugador representado por un hámster con mostacho y un soldado el cual vigila el portón del castillo. La idea es que cuando el jugador se acerque al guardia, este le salude y abra la puerta.

1) Todos los sprites utilizados los he dibujado utilizando **Krita**.
2) Generé los spritesheets de las animaciones riggeando el personaje y animándolo con **Spriter**. 
3) La propiedad *Flip* voltea horizontalmente el Sprite Renderer, no obstante, es mejor multiplicar la escala (X) del Transform del GameObject por -1, ya que de este modo haremos *Flip* a todos sus componentes.
4) Se ha creado la clase **PlayerController**, que define el movimiento del personaje.
5) Cuando el hámster del jugador llega al soldado de la torre, este le saluda y abre el portón del castillo. La comprobación se realiza a través del script **DoorTrigger**, el cual activa las animaciones del soldado y la puerta cuando el jugador llega a su posición.

Como el gif completo ocupaba demasiado, dejo el enlace a un vídeo de youtube:
https://youtu.be/Q42tzCzkFws

![](Gif-FDV2.gif)
