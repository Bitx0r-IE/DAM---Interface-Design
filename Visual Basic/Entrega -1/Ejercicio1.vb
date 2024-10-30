'' Dise�a un programa que obtenga la calificaci�n mayor y la calificaci�n
'' menor, de un grupo de 40 estudiantes, adem�s de los nombres de dichos
'' alumnos.

Module Modul1e1
    Sub Main()
        ' Declaraci�n de variables para almacenar nombres y calificaciones
        Dim nombres(39) As String
        Dim calificaciones(39) As Double
        Dim nombreMayor As String = ""
        Dim nombreMenor As String = ""
        Dim calificacionMayor As Double = -1
        Dim calificacionMenor As Double = 101

        ' Bucle para ingresar nombres y calificaciones
        For i As Integer = 0 To 39
            Console.Write("Ingrese el nombre del estudiante {0}: ", i + 1)
            nombres(i) = Console.ReadLine()

            Console.Write("Ingrese la calificaci�n del estudiante {0}: ", i + 1)
            calificaciones(i) = Convert.ToDouble(Console.ReadLine())

            ' Verificar si es la calificaci�n mayor
            If calificaciones(i) > calificacionMayor Then
                calificacionMayor = calificaciones(i)
                nombreMayor = nombres(i)
            End If

            ' Verificar si es la calificaci�n menor
            If calificaciones(i) < calificacionMenor Then
                calificacionMenor = calificaciones(i)
                nombreMenor = nombres(i)
            End If
        Next

        ' Mostrar resultados
        Console.WriteLine()
        Console.WriteLine("El estudiante con la calificaci�n mayor es: " & nombreMayor & " con " & calificacionMayor)
        Console.WriteLine("El estudiante con la calificaci�n menor es: " & nombreMenor & " con " & calificacionMenor)

        Console.WriteLine("Presiona cualquier tecla para finalizar...")
        Console.ReadKey()
    End Sub
End Module
