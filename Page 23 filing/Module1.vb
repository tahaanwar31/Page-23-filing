Module Module1
    Sub Main()
        Preview()
    End Sub
    Sub Preview()
        Dim data As String
        Dim count As Integer
        data = ""
        count = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\textfile.txt", OpenMode.Input)
        If EOF(1) Then
            Console.Writeline("File is empty")
        Else
            While Not EOF(1) And count <= 5
                Input(1, data)
                Console.WriteLine(data)
                count = count + 1
            End While
        End If
        FileClose(1)
        Console.ReadKey()
    End Sub
End Module
