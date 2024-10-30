'' Diseña un programa que obtenga la calificación mayor y la calificación
'' menor, de un grupo de 40 estudiantes, además de los nombres de dichos
'' alumnos.

Module Modul1e1
    Sub Main()
        ' Declaración de variables para almacenar nombres y calificaciones
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

            Console.Write("Ingrese la calificación del estudiante {0}: ", i + 1)
            calificaciones(i) = Convert.ToDouble(Console.ReadLine())

            ' Verificar si es la calificación mayor
            If calificaciones(i) > calificacionMayor Then
                calificacionMayor = calificaciones(i)
                nombreMayor = nombres(i)
            End If

            ' Verificar si es la calificación menor
            If calificaciones(i) < calificacionMenor Then
                calificacionMenor = calificaciones(i)
                nombreMenor = nombres(i)
            End If
        Next

        ' Mostrar resultados
        Console.WriteLine()
        Console.WriteLine("El estudiante con la calificación mayor es: " & nombreMayor & " con " & calificacionMayor)
        Console.WriteLine("El estudiante con la calificación menor es: " & nombreMenor & " con " & calificacionMenor)

        Console.WriteLine("Presiona cualquier tecla para finalizar...")
        Console.ReadKey()
    End Sub
End Module
