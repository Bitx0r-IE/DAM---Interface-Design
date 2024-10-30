'Realizar un programa que guarde los datos de los departamentos de nuestra empresa.
'De cada departamento queremos saber el nombre del departamento, persona responsable del
'departamento y las personas empleadas.
'De cada persona queremos saber su nombre, primer apellido y segundo apellido, además de en qué
'departamento trabaja.
'No en todos los departamentos habrá el mismo número de personas trabajando.
'Una vez insertados todos los datos, los visualizaremos.

Module Module1
    ' Clase para almacenar información de cada persona
    Class Persona
        Public Property Nombre As String
        Public Property PrimerApellido As String
        Public Property SegundoApellido As String
        Public Property Departamento As String

        Public Sub New(nombre As String, primerApellido As String, segundoApellido As String, departamento As String)
            Me.Nombre = nombre
            Me.PrimerApellido = primerApellido
            Me.SegundoApellido = segundoApellido
            Me.Departamento = departamento
        End Sub

        Public Overrides Function ToString() As String
            Return Nombre & " " & PrimerApellido & " " & SegundoApellido & " - Departamento: " & Departamento
        End Function
    End Class

    ' Clase para almacenar información de cada departamento
    Class Departamento
        Public Property Nombre As String
        Public Property Responsable As String
        Public Property Empleados As New List(Of Persona)

        Public Sub New(nombre As String, responsable As String)
            Me.Nombre = nombre
            Me.Responsable = responsable
        End Sub

        Public Sub AgregarEmpleado(empleado As Persona)
            Empleados.Add(empleado)
        End Sub

        Public Overrides Function ToString() As String
            Dim info As String = "Departamento: " & Nombre & " - Responsable: " & Responsable & vbCrLf
            info &= "Empleados:" & vbCrLf
            For Each empleado As Persona In Empleados
                info &= "  - " & empleado.ToString() & vbCrLf
            Next
            Return info
        End Function
    End Class

    Sub Main()
        Dim departamentos As New List(Of Departamento)
        Dim continuar As Boolean = True

        ' Insertar datos de departamentos y empleados
        Do
            Console.WriteLine("Ingrese el nombre del departamento:")
            Dim nombreDepto As String = Console.ReadLine()

            Console.WriteLine("Ingrese el nombre del responsable del departamento:")
            Dim responsableDepto As String = Console.ReadLine()

            Dim depto As New Departamento(nombreDepto, responsableDepto)

            Console.WriteLine("¿Cuántos empleados desea agregar en el departamento " & nombreDepto & "?")
            Dim numEmpleados As Integer = Convert.ToInt32(Console.ReadLine())

            For i As Integer = 1 To numEmpleados
                Console.WriteLine("Ingrese los datos del empleado " & i & ":")

                Console.Write("Nombre: ")
                Dim nombreEmpleado As String = Console.ReadLine()

                Console.Write("Primer apellido: ")
                Dim primerApellido As String = Console.ReadLine()

                Console.Write("Segundo apellido: ")
                Dim segundoApellido As String = Console.ReadLine()

                ' Crear empleado y asignar al departamento
                Dim empleado As New Persona(nombreEmpleado, primerApellido, segundoApellido, nombreDepto)
                depto.AgregarEmpleado(empleado)
            Next

            departamentos.Add(depto)

            Console.WriteLine("¿Desea agregar otro departamento? (s/n): ")
            Dim respuesta As String = Console.ReadLine().ToLower()
            If respuesta <> "s" Then
                continuar = False
            End If

        Loop While continuar

        ' Mostrar todos los datos ingresados
        Console.WriteLine("Datos de los departamentos y empleados:")
        For Each depto As Departamento In departamentos
            Console.WriteLine(depto.ToString())
        Next

        Console.WriteLine("Presione cualquier tecla para finalizar...")
        Console.ReadKey()
    End Sub
End Module
