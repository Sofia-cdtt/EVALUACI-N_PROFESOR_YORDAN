def Ejercicio1():
    #Inicio
    edad = de

def Ejercicio2():
    #Inicio
    import math

    #Declramos variables
    nota = int(input("Buen d�a. Ingrese su nota de [0-20]: "))
    
    #Validaci�n
    if nota < 0 or nota > 20:
        print("Error: La nota ingresada debe estar entre [0-20]")

    else: 
        #Clasificaci�n seg�n la nota
        if 0 <= nota <= 10:
            print("Su calificaci�n es Desaprobado.")
        elif 11 <= nota <= 13:
            print("Su calificaci�n es Regular.")
        
        elif 14 <= nota <= 17:
            print("Su calificaci�n es Bueno.")
        
        elif 18 <= nota <= 20:
            print("Su calificaci�n es Excelente.")

        else:
            print("Error inesperado en la clasificaci�n.")

        #Condiciones con operadores l�gicos
        if nota >= 14 and nota % 2 == 0:
            print("Buen desempe�o con nota par. ")

        if nota % 2 != 0 or nota < 11:
            print("Necesita reforzar. ")

        # Calculamos la ra�z cuadrada y la potencia al cubo
        raiz_cuadrada = math.sqrt(nota)
        potencia_cubo = math.pow(nota, 3)

        #Final
        print(f"La ra�z cuadrada es: {raiz_cuadrada:.1f}")
        print(f"La potencia al cubo es: {potencia_cubo}")

Ejercicio1()