import sys
# Abrir cada fichero y quitar repetidos
palabras = []
for i in range(1,len(sys.argv)):
	fichero = open(sys.argv[i],'r')
	palabras = fichero.readline().split(',')
	palabras = set(palabras)
	salida = open(sys.argv[i],'w')
	for word in palabras:
		salida.write(word)
fichero.close()
salida.close()
