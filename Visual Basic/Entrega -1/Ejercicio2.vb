'Realizar un programa que a través de un menú permita realizar las
'operaciones de sumar, restar, multiplicar, dividir y salir. Las operaciones
'constarán solamente de dos operandos y cada una tendrá su propio
'procedimiento.

Module Module1
    Sub Main()
        Dim opcion As Integer

        Do
            Console.WriteLine("Seleccione una operación:")
            Console.WriteLine("1. Sumar")
            Console.WriteLine("2. Restar")
            Console.WriteLine("3. Multiplicar")
            Console.WriteLine("4. Dividir")
            Console.WriteLine("5. Salir")
            Console.Write("Ingrese su opción: ")
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
                    Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 5.")
            End Select
            Console.WriteLine()

        Loop While opcion <> 5
    End Sub

    Sub Sumar()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer número: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        b = Convert.ToDouble(Console.ReadLine())

        Dim resultado As Double = a + b
        Console.WriteLine("Resultado de la suma: " & resultado)
    End Sub

    Sub Restar()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer número: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        b = Convert.ToDouble(Console.ReadLine())

        Dim resultado As Double = a - b
        Console.WriteLine("Resultado de la resta: " & resultado)
    End Sub

    Sub Multiplicar()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer número: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        b = Convert.ToDouble(Console.ReadLine())

        Dim resultado As Double = a * b
        Console.WriteLine("Resultado de la multiplicación: " & resultado)
    End Sub

    Sub Dividir()
        Dim a As Double
        Dim b As Double

        Console.Write("Ingrese el primer número: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        b = Convert.ToDouble(Console.ReadLine())

        If b <> 0 Then
            Dim resultado As Double = a / b
            Console.WriteLine("Resultado de la división: " & resultado)
        Else
            Console.WriteLine("Error: No se puede dividir entre cero.")
        End If
    End Sub
End Module
