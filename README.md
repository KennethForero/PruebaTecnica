🎮 Sistema de Generación Aleatoria de Objetos en Unity
Este proyecto implementa un sistema de generación aleatoria de objetos con contador visual en la UI. Los objetos se generan automáticamente cada cierto tiempo, tienen colores aleatorios, y pueden ser eliminados con clic izquierdo del mouse.

🚀 Cómo probar la funcionalidad
**1. Clona el repositorio**
bash
Copiar
Editar
git clone https://github.com/KennethForero/PruebaTecnica.git

**2. Abre el proyecto en Unity**
Versión utilizada: Unity 6000.0.46f1

Abre la escena principal ubicada en:
Assets/Scenes/SampleScene.unity

**3. Ejecuta la escena**
Haz clic en Play dentro del editor.
Se generará un objeto cada 2 segundos, hasta un máximo de 10 objetos activos.
Puedes hacer clic izquierdo sobre un objeto para destruirlo.
Al destruirse un objeto, se permite generar uno nuevo.
El contador en pantalla se actualiza automáticamente en tiempo real.


**📦 Estructura del proyecto**
Scripts/Spawner.cs: Lógica de generación de objetos en posiciones aleatorias.

Scripts/ClickDestruction.cs: Permite destruir objetos con clic izquierdo (raycast).



✅ Funcionalidades principales
🔄 Generación automática de objetos cada 2 segundos.
🎯 Posiciones aleatorias dentro de un área (X: -5 a 5, Z: -5 a 5).
🔟 Máximo de 10 objetos activos en escena.
🖱️ Destrucción de objetos con clic izquierdo del mouse.
🌈 Color aleatorio al momento de la creación.
📊 UI con contador de objetos activos, actualizado dinámicamente.



🎥 Mira el video de demostración aquí:
🔗 Ver en Google Drive

