Imports teamGen

Module Program
    Sub Main(args As String())
        If args(0) = "test" Then
            Console.WriteLine(Generator.essentials18("Bulbasaur", "", 5, "0", "Male", 0, "Bold", 70, "Bloom", "Pokeball", False,
            False, False, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
            Console.WriteLine("Test Success!")
        ElseIf args.count < 24 Then
            Help()
            Environment.ExitCode = -1

        ElseIf args.count > 30 Then
            Help()
            Environment.ExitCode = -2
        ElseIf args(0) = "17" Then

        ElseIf args(0) = "18" Then
            Console.WriteLine(Generator.essentials18(args(1), args(2), Integer.Parse(args(3)), args(4), args(5), Integer.Parse(args(6)), args(7), Integer.Parse(args(8)), args(9), args(10), Boolean.Parse(args(11)),
            Boolean.Parse(args(12)), Boolean.Parse(args(13)), Integer.Parse(args(14)), Integer.Parse(args(15)), Integer.Parse(args(16)), Integer.Parse(args(17)), Integer.Parse(args(17)), Integer.Parse(args(18)),
            Integer.Parse(args(19)), Integer.Parse(args(20)), Integer.Parse(args(21)), Integer.Parse(args(22)), Integer.Parse(args(23)), Integer.Parse(args(24))))

            Console.WriteLine("Team Generated Sucessfully!")
        Else
            Help()
            Environment.ExitCode = 1
        End If
    End Sub

    Private Sub Help()

    End Sub
End Module
