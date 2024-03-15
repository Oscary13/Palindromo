Imports System
Imports System.Threading

Module Program

    'Function EsPalindromo(ByVal palabra As String) As Boolean
    '    Dim dato As String = palabra.ToLower().Replace("[\W_]/g", "")
    '    Return dato = StrReverse(palabra)

    'End Function

    'Sub Main(args As String())
    '    Console.WriteLine("¿La palabra es palindromo? " & EsPalindromo("anita_laba_la_tina"))
    '    Console.ReadLine()
    'End Sub

    'Sub Main()
    '    Dim palabra As String = "anita_laba_la_tina"
    '    Console.WriteLine("¿La palabra es un palíndromo? " & esPalindromo(palabra))
    '    Console.ReadLine()
    'End Sub

    'Function esPalindromo(palabra As String) As Boolean
    '    palabra = palabra.ToLower().Replace("[\W_]", "") ' Elimina caracteres no alfabéticos y convierte a minúsculas
    '    Dim reversed As String = StrReverse(palabra)
    '    Return palabra = reversed
    'End Function


    Sub Main()

        Dim respuesta As String
        Do
            Dim palabra As String
            Do
                Console.Clear()
                Console.WriteLine("Ingrese una palabra para verificar si es un palíndromo:")
                Console.WriteLine()
                palabra = Console.ReadLine()
            Loop Until palabra <> ""
            Console.WriteLine()

            If esPalindromo(palabra) = True Then
                Console.WriteLine("¡La palabra '" & palabra & "' es un palíndromo!")
            ElseIf esPalindromo(palabra) = False Then
                Console.WriteLine("¡La palabra '" & palabra & "' no es un palíndromo!")
            End If
            Console.WriteLine()
            Do
                Console.WriteLine("¿Desea ingresar otra palabra? (s/n)")
                Console.WriteLine()
                respuesta = Console.ReadLine()
                Console.Clear()
                If respuesta.ToLower() <> "s" AndAlso respuesta.ToLower() <> "n" Then
                    Console.WriteLine("Respuesta incorrecta. Por favor, ingrese 's' o 'n'.")
                    Thread.Sleep(2000)
                    Console.Clear()
                End If
            Loop Until respuesta.ToLower() = "s" OrElse respuesta.ToLower() = "n"
        Loop While respuesta.ToLower() = "s"


    End Sub


    Function esPalindromo(ByVal palabra As String) As Boolean
        palabra = System.Text.RegularExpressions.Regex.Replace(palabra, "[^\w]", "") ' Elimina caracteres no alfabéticos
        Dim reversed As String = StrReverse(palabra)
        Return palabra = reversed
    End Function

End Module
