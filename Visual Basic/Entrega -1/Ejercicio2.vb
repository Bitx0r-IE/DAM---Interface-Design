'Realizar un programa que a trav�s de un men� permita realizar las
'operaciones de sumar, restar, multiplicar, dividir y salir. Las operaciones
'constar�n solamente de dos operandos y cada una tendr� su propio
'procedimiento.

Module Module1
    Sub Main()
        Dim opcion As Integer

        Do
            Console.WriteLine("Seleccione una operaci�n:")
            Console.WriteLine("1. Sumar")
            Console.WriteLine("2. Restar")
            Console.WriteLine("3. Multiplicar")
            Console.WriteLine("4. Dividir")
            Console.WriteLine("5. Salir")
            Console.Write("Ingrese su opci�n: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    Sumar()
                Case 2
                    Restar()
                Case 3
                    Multiplicar()
                Case 4
                    Dividir()
                Case 5
                    Console.WriteLine("Saliendo del programa...")
                Case Else
                    Console.WriteLine("Opci�n inv�lida. Por favor, elija una opci�n del 1 al 5.")
            End Select
            Console.WriteLine()

        Loop While opcion <> 5
    End Sub

    Sub Sumar()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer n�mero: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo n�mero: ")
        b = Convert.ToDouble(Console.ReadLine())

        Dim resultado As Double = a + b
        Console.WriteLine("Resultado de la suma: " & resultado)
    End Sub

    Sub Restar()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer n�mero: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo n�mero: ")
        b = Convert.ToDouble(Console.ReadLine())

        Dim resultado As Double = a - b
        Console.WriteLine("Resultado de la resta: " & resultado)
    End Sub

    Sub Multiplicar()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer n�mero: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo n�mero: ")
        b = Convert.ToDouble(Console.ReadLine())

        Dim resultado As Double = a * b
        Console.WriteLine("Resultado de la multiplicaci�n: " & resultado)
    End Sub

    Sub Dividir()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer n�mero: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo n�mero: ")
        b = Convert.ToDouble(Console.ReadLine())

        If b <> 0 Then
            Dim resultado As Double = a / b
            Console.WriteLine("Resultado de la divisi�n: " & resultado)
        Else
            Console.WriteLine("Error: No se puede dividir entre cero.")
        End If
    End Sub
End Module
