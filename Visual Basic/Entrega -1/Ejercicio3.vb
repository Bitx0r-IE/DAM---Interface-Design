'Crear un programa que vaya pidiendo n�meros. Estos n�meros se guardar�n en una lista, y cuando el usuario no
'quiera insertar m�s le mostraremos un men� con las siguientes opciones
'1.- Multiplicar por tres los n�meros pares.
'2.- Multiplicar por dos todos los n�meros.
'3.- A�adir un n�mero al final
'4.- A�adir un n�mero al principio
'5.- A�adir un n�mero en una posici�n concreta.
'6.- Borrar el �ltimo elemento
'7.- Borrar el primer elemento
'8.- Borrar un elemento en una posici�n concreta.
'9.- Buscar un elemento.
'10.- Ordenar los elementos de un array.
'11.- Salir.

Module Module1
    Sub Main()
        Dim listaNumeros As New List(Of Integer)
        Dim opcion As Integer

        ' Ingresar n�meros en la lista
        Console.WriteLine("Ingrese n�meros (escriba 'fin' para detener la entrada):")
        While True
            Dim entrada As String = Console.ReadLine()
            If entrada.ToLower() = "fin" Then
                Exit While
            End If
            Try
                listaNumeros.Add(Convert.ToInt32(entrada))
            Catch ex As Exception
                Console.WriteLine("Por favor, ingrese un n�mero v�lido.")
            End Try
        End While

        ' Men� de opciones
        Do
            Console.WriteLine("Seleccione una opci�n:")
            Console.WriteLine("1.- Multiplicar por tres los n�meros pares.")
            Console.WriteLine("2.- Multiplicar por dos todos los n�meros.")
            Console.WriteLine("3.- A�adir un n�mero al final.")
            Console.WriteLine("4.- A�adir un n�mero al principio.")
            Console.WriteLine("5.- A�adir un n�mero en una posici�n concreta.")
            Console.WriteLine("6.- Borrar el �ltimo elemento.")
            Console.WriteLine("7.- Borrar el primer elemento.")
            Console.WriteLine("8.- Borrar un elemento en una posici�n concreta.")
            Console.WriteLine("9.- Buscar un elemento.")
            Console.WriteLine("10.- Ordenar los elementos.")
            Console.WriteLine("11.- Salir.")
            Console.Write("Ingrese su opci�n: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    MultiplicarParesPorTres(listaNumeros)
                Case 2
                    MultiplicarTodosPorDos(listaNumeros)
                Case 3
                    A�adirAlFinal(listaNumeros)
                Case 4
                    A�adirAlPrincipio(listaNumeros)
                Case 5
                    A�adirEnPosicion(listaNumeros)
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
                    Console.WriteLine("Opci�n inv�lida. Por favor, elija una opci�n del 1 al 11.")
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
        Console.WriteLine("Se han multiplicado por tres los n�meros pares.")
    End Sub

    Sub MultiplicarTodosPorDos(ByRef lista As List(Of Integer))
        For i As Integer = 0 To lista.Count - 1
            lista(i) *= 2
        Next
        Console.WriteLine("Se han multiplicado todos los n�meros por dos.")
    End Sub

    Sub A�adirAlFinal(ByRef lista As List(Of Integer))
        Console.Write("Ingrese el n�mero a a�adir al final: ")
        lista.Add(Convert.ToInt32(Console.ReadLine()))
    End Sub

    Sub A�adirAlPrincipio(ByRef lista As List(Of Integer))
        Console.Write("Ingrese el n�mero a a�adir al principio: ")
        lista.Insert(0, Convert.ToInt32(Console.ReadLine()))
    End Sub

    Sub A�adirEnPosicion(ByRef lista As List(Of Integer))
        Console.Write("Ingrese la posici�n donde quiere a�adir el n�mero: ")
        Dim posicion As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Ingrese el n�mero a a�adir: ")
        Dim numero As Integer = Convert.ToInt32(Console.ReadLine())
        If posicion >= 0 And posicion <= lista.Count Then
            lista.Insert(posicion, numero)
        Else
            Console.WriteLine("Posici�n fuera de rango.")
        End If
    End Sub

    Sub BorrarUltimo(ByRef lista As List(Of Integer))
        If lista.Count > 0 Then
            lista.RemoveAt(lista.Count - 1)
        Else
            Console.WriteLine("La lista est� vac�a.")
        End If
    End Sub

    Sub BorrarPrimero(ByRef lista As List(Of Integer))
        If lista.Count > 0 Then
            lista.RemoveAt(0)
        Else
            Console.WriteLine("La lista est� vac�a.")
        End If
    End Sub

    Sub BorrarEnPosicion(ByRef lista As List(Of Integer))
        Console.Write("Ingrese la posici�n del elemento a borrar: ")
        Dim posicion As Integer = Convert.ToInt32(Console.ReadLine())
        If posicion >= 0 And posicion < lista.Count Then
            lista.RemoveAt(posicion)
        Else
            Console.WriteLine("Posici�n fuera de rango.")
        End If
    End Sub

    Sub BuscarElemento(ByRef lista As List(Of Integer))
        Console.Write("Ingrese el n�mero a buscar: ")
        Dim numero As Integer = Convert.ToInt32(Console.ReadLine())
        Dim posicion As Integer = lista.IndexOf(numero)
        If posicion <> -1 Then
            Console.WriteLine("El n�mero se encuentra en la posici�n: " & posicion)
        Else
            Console.WriteLine("El n�mero no se encuentra en la lista.")
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
