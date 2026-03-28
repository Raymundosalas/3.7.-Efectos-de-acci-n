
#  Proyecto: Sistema de Misiles en Unity 2D

##  Descripción

Este proyecto consiste en la implementación de un sistema de disparo de misiles en un entorno 2D utilizando Unity. Se desarrolló como parte de una actividad académica, con el objetivo de simular la trayectoria de un proyectil y añadir efectos visuales que mejoren la experiencia del usuario.

El sistema incluye movimiento físico, rotación automática, efectos de partículas y explosiones al impacto.

---

##  Objetivos

* Simular la trayectoria de un misil en 2D.
* Implementar física básica con Rigidbody2D.
* Añadir efectos visuales como humo y explosión.
* Aplicar rotación dinámica basada en la velocidad.
* Integrar interacción mediante entrada del usuario.

---

##  Tecnologías utilizadas

* Unity 2D
* C#
* Rigidbody2D (física)
* Particle System (efectos visuales)

---

##  Funcionalidades

* Disparo de misiles al presionar una tecla (espacio).
* Movimiento en línea recta o trayectoria parabólica.
* Rotación automática del misil según su dirección.
* Generación de efecto de humo durante el recorrido.
* Explosión al colisionar con otro objeto.
* Destrucción automática del misil tras cierto tiempo.

---

##  Estructura del proyecto

```
Assets/
 ├── Scripts/
 │    ├── Missile.cs
 │    ├── MissileLauncher.cs
 │    ├── Explosion.cs
 │    └── SmokeTrail.cs
 ├── Prefabs/
 │    ├── Missile.prefab
 │    └── Explosion.prefab
 ├── Scenes/
 │    └── Main.unity
```



---

## Implementación técnica

### Movimiento del misil

Se utiliza un `Rigidbody2D` para aplicar velocidad constante en la dirección del objeto.

### Rotación dinámica

El misil rota automáticamente utilizando funciones trigonométricas (`Atan2`) para alinearse con su velocidad.

### Efectos visuales

* **Humo:** generado con un sistema de partículas.
* **Explosión:** instanciada al detectar colisión.

### Colisiones

Se detectan mediante `OnCollisionEnter2D`, lo que activa la explosión y destruye el misil.

---





## Conclusión 

En este proyecto aprendí a implementar físicas en Unity 2D para simular trayectorias de proyectiles, así como a integrar efectos visuales que mejoran la experiencia del usuario. También comprendí mejor el uso de componentes como Rigidbody2D y los sistemas de partículas. Considero que esta práctica me permitió reforzar mis habilidades en programación con C# dentro del desarrollo de videojuegos.

---

##  Referencias 

* Unity Technologies. (2021). *Unity User Manual*. [https://docs.unity3d.com](https://docs.unity3d.com)
* Unity Technologies. (2021). *Rigidbody2D*. [https://docs.unity3d.com/ScriptReference/Rigidbody2D.html](https://docs.unity3d.com/ScriptReference/Rigidbody2D.html)
* Brackeys. (2021). *Unity 2D Tutorial*. YouTube.
* Mignano, M. (s.f.). *Diseño de mecánicas de juego con prototipos*.

---

##  Autor

Raymundo Salas Rodríguez

