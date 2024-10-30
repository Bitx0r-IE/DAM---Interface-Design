'Crear un programa que vaya pidiendo números. Estos números se guardarán en una lista, y cuando el usuario no
'quiera insertar más le mostraremos un menú con las siguientes opciones
'1.- Multiplicar por tres los números pares.
'2.- Multiplicar por dos todos los números.
'3.- Añadir un número al final
'4.- Añadir un número al principio
'5.- Añadir un número en una posición concreta.
'6.- Borrar el último elemento
'7.- Borrar el primer elemento
'8.- Borrar un elemento en una posición concreta.
'9.- Buscar un elemento.
'10.- Ordenar los elementos de un array.
'11.- Salir.

Module Module1
    Sub Main()
        Dim listaNumeros As New List(Of Integer)
        Dim opcion As Integer

        ' Ingresar números en la lista
        Console.WriteLine("Ingrese números (escriba 'fin' para detener la entrada):")
        While True
            Dim entrada As String = Console.ReadLine()
            If entrada.ToLower() = "fin" Then
                Exit While
            End If
            Try
                listaNumeros.Add(Convert.ToInt32(entrada))
            Catch ex As Exception
                Console.WriteLine("Por favor, ingrese un número válido.")
            End Try
        End While

        ' Menú de opciones
        Do
            Console.WriteLine("Seleccione una opción:")
            Console.WriteLine("1.- Multiplicar por tres los números pares.")
            Console.WriteLine("2.- Multiplicar por dos todos los números.")
            Console.WriteLine("3.- Añadir un número al final.")
            Console.WriteLine("4.- Añadir un número al principio.")
            Console.WriteLine("5.- Añadir un número en una posición concreta.")
            Console.WriteLine("6.- Borrar el último elemento.")
            Console.WriteLine("7.- Borrar el primer elemento.")
            Console.WriteLine("8.- Borrar un elemento en una posición concreta.")
            Console.WriteLine("9.- Buscar un elemento.")
            Console.WriteLine("10.- Ordenar los elementos.")
            Console.WriteLine("11.- Salir.")
            Console.Write("Ingrese su opción: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    MultiplicarParesPorTres(listaNumeros)
                Case 2
                    MultiplicarTodosPorDos(listaNumeros)
                Case 3
                    AñadirAlFinal(listaNumeros)
                Case 4
                    AñadirAlPrincipio(listaNumeros)
                Case 5
                    AñadirEnPosicion(listaNumeros)
                Case 6
                    BorrarUltimo(listaNumeros)
                Case 7
                    BorrarPrimero(listaNumeros)
                Case 8
                    BorrarEnPosicion(listaNumeros)
                Case 9
                    BuscarElemento(listaNumeros)
                Case 10
                    OrdenarElementos(listaNumeros)
                Case 11
                    Console.WriteLine("Saliendo del programa...")
                Case Else
                    Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 11.")
            End Select
            Console.WriteLine()
            MostrarLista(listaNumeros)

        Loop While opcion <> 11
    End Sub

    Sub MultiplicarParesPorTres(ByRef lista As List(Of Integer))
        For i As Integer = 0 To lista.Count - 1
            If lista(i) Mod 2 = 0 Then
                lista(i) *= 3
            End If
        Next
        Console.WriteLine("Se han multiplicado por tres los números pares.")
    End Sub

    Sub MultiplicarTodosPorDos(ByRef lista As List(Of Integer))
        For i As Integer = 0 To lista.Count - 1
            lista(i) *= 2
        Next
        Console.WriteLine("Se han multiplicado todos los números por dos.")
    End Sub

    Sub AñadirAlFinal(ByRef lista As List(Of Integer))
        Console.Write("Ingrese el número a añadir al final: ")
        lista.Add(Convert.ToInt32(Console.ReadLine()))
    End Sub

    Sub AñadirAlPrincipio(ByRef lista As List(Of Integer))
        Console.Write("Ingrese el número a añadir al principio: ")
        lista.Insert(0, Convert.ToInt32(Console.ReadLine()))
    End Sub

    Sub AñadirEnPosicion(ByRef lista As List(Of Integer))
        Console.Write("Ingrese la posición donde quiere añadir el número: ")
        Dim posicion As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Ingrese el número a añadir: ")
        Dim numero As Integer = Convert.ToInt32(Console.ReadLine())
        If posicion >= 0 And posicion <= lista.Count Then
            lista.Insert(posicion, numero)
        Else
            Console.WriteLine("Posición fuera de rango.")
        End If
    End Sub

    Sub BorrarUltimo(ByRef lista As List(Of Integer))
        If lista.Count > 0 Then
            lista.RemoveAt(lista.Count - 1)
        Else
            Console.WriteLine("La lista está vacía.")
        End If
    End Sub

    Sub BorrarPrimero(ByRef lista As List(Of Integer))
        If lista.Count > 0 Then
            lista.RemoveAt(0)
        Else
            Console.WriteLine("La lista está vacía.")
        End If
    End Sub

    Sub BorrarEnPosicion(ByRef lista As List(Of Integer))
        Console.Write("Ingrese la posición del elemento a borrar: ")
        Dim posicion As Integer = Convert.ToInt32(Console.ReadLine())
        If posicion >= 0 And posicion < lista.Count Then
            lista.RemoveAt(posicion)
        Else
            Console.WriteLine("Posición fuera de rango.")
        End If
    End Sub

    Sub BuscarElemento(ByRef lista As List(Of Integer))
        Console.Write("Ingrese el número a buscar: ")
        Dim numero As Integer = Convert.ToInt32(Console.ReadLine())
        Dim posicion As Integer = lista.IndexOf(numero)
        If posicion <> -1 Then
            Console.WriteLine("El número se encuentra en la posición: " & posicion)
        Else
            Console.WriteLine("El número no se encuentra en la lista.")
        End If
    End Sub

    Sub OrdenarElementos(ByRef lista As List(Of Integer))
        lista.Sort()
        Console.WriteLine("La lista ha sido ordenada.")
    End Sub

    Sub MostrarLista(ByVal lista As List(Of Integer))
        Console.WriteLine("Lista actual:")
        For Each num In lista
            Console.Write(num & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
