
def Ejercicio1():
    #Inicio
    precio_producto = float(input("Buen día. Ingrese el precio del producto elegido: "))
    print("Elige un código: ")
    print("=================")
    print("[1] - Estudiante")
    print("[2] - Empleado")
    print("[3] - Cliente frecuente")
    print("=================")
    codigo = int(input())



def Ejercicio2():
    #Inicio
    import math

    #Declramos variables
    nota = int(input("Buen día. Ingrese su nota de [0-20]: "))
    
    #Validación
    if nota < 0 or nota > 20:
        print("Error: La nota ingresada debe estar entre [0-20]")

    else: 
        #Clasificación según la nota
        if 0 <= nota <= 10:
            print("Su calificación es Desaprobado.")
        elif 11 <= nota <= 13:
            print("Su calificación es Regular.")
        
        elif 14 <= nota <= 17:
            print("Su calificación es Bueno.")
        
        elif 18 <= nota <= 20:
            print("Su calificación es Excelente.")

        else:
            print("Error inesperado en la clasificación.")

        #Condiciones con operadores lógicos
        if nota >= 14 and nota % 2 == 0:
            print("Buen desempeño con nota par. ")

        if nota % 2 != 0 or nota < 11:
            print("Necesita reforzar. ")

        # Calculamos la raíz cuadrada y la potencia al cubo
        raiz_cuadrada = math.sqrt(nota)
        potencia_cubo = math.pow(nota, 3)

        #Final
        print(f"La raíz cuadrada es: {raiz_cuadrada:.1f}")
        print(f"La potencia al cubo es: {potencia_cubo}")

Ejercicio2()
