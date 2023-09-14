Public Class Calculator

    Public Sub Add(firstNum As Integer, secNum As Integer)

        Dim result As Integer
        result = firstNum + secNum
        Console.WriteLine("The addition result is: " & result)

    End Sub


    Public Sub Subtract(firstNum As Integer, secondNum As Integer)
        Dim result As Integer
        Try
            result = firstNum - secondNum
            Console.WriteLine("The Subtraction result is: " & result)

        Catch ex As Exception
            Console.WriteLine("Error in Subtract: " + ex.Message)
        End Try
    End Sub

    Public Sub Multiply(firstNum As Integer, secondNum As Integer)

        Dim result As Integer
        Try
            result = firstNum * secondNum
            Console.WriteLine("The Multipication result is: " & result)

        Catch ex As Exception
            Console.WriteLine("Error in Multiply: " & ex.Message)
        End Try
    End Sub

    Public Sub Divide(firstNum As Decimal, secondNum As Decimal)

        Try
            Dim result As Decimal
            result = firstNum / secondNum
            Console.WriteLine("The divison result is: " & result)

        Catch ex As Exception
            Console.WriteLine("Error in Divison: " + ex.Message)
        End Try

    End Sub



End Class
