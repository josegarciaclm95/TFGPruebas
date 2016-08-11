Prototipo basado en Microsoft Oxford API
========================================

Este repositorio contiene el prototipo desarrollado en C# para la detección de emociones.

Algoritmo
===============
El grueso del prototipo recae en el método que se desencadena al hacer click en "Analyse Feelings".

AnalyseFeeling_Click {
	-Eliminar imágenes que haya en el directorio, que haya una foto como mucho en cada instante
	-Tomar imagen
	-Mandar a Oxford API
	-Adaptar resultados
	-Registrar resultados
}

La adaptación consiste en coger los resultados que devuelve la API (donde las emociones son propiedades del objeto devuelto) y transformarlo en objetos _Emotion.

La lógica que decide como analizar las emociones se encuentra en study_emotions(), en Prototipo.xaml.cs. Según el score de la emoción mayor, se decide cual es la emoción que está mostrando el usuario.

-   Si la emoción mayor tiene un score mayor de 0.9, dedicidimos que esa emoción es la que se esta mostrando
-   Si es menor, entonces delegamos el estudio en la propia clase primaria, que analiza cuales son las emociones        secundarias y decide entonces que emoción constituye la combinacion de estas.

