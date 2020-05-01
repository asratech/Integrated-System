Imports System.Text.RegularExpressions
Module MdlGeneral
    Sub xRegex(ByVal text As String, ByVal expr As String)
        Console.WriteLine("The Expression: " + expr)
        Dim Sc As MatchCollection = Regex.Matches(text, expr)
        Dim Cari As Match
        For Each Cari In Sc
            Console.WriteLine(Cari)
        Next Cari
    End Sub
End Module
