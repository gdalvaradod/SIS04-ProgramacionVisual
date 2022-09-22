'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    Sub Main()
        Dim num1, num2, num3 As Integer
        Console.Write("Ingrese primer valor:")
        num1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor:")
        num2 = Console.ReadLine()
        Console.Write("Ingrese tercer valor:")
        num3 = Console.ReadLine()
        If num1 > num2 And num1 > num3 Then
            Console.Write(num1)
        Else
            If num2 > num3 Then
                Console.Write(num2)
            Else
                Console.Write(num3)
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
