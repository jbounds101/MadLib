
Module Module1
        Dim Adj1 As String
        Dim Noun1 As String
        Dim Noun2 As String
        Dim Adj2 As String
        Dim Noun3 As String
        Dim Noun4 As String
        Dim Noun5 As String
        Dim Adj3 As String
        Dim PNoun1 As String
        Dim Adverb1 As String
        Dim PNoun2 As String
        Dim yn As String = "Yes"
        Sub Main()
            Do
                Console.WriteLine("Adjective:")
                Adj1 = Console.ReadLine
                Console.WriteLine("Noun:")
                Noun1 = Console.ReadLine
                Console.WriteLine("Noun:")
                Noun2 = Console.ReadLine
                Console.WriteLine("Adjective:")
                Adj2 = Console.ReadLine
                Console.WriteLine("Noun:")
                Noun3 = Console.ReadLine
                Console.WriteLine("Noun:")
                Noun4 = Console.ReadLine
                Console.WriteLine("Noun:")
                Noun5 = Console.ReadLine
                Console.WriteLine("Adjective:")
                Adj3 = Console.ReadLine
                Console.WriteLine("Plural Noun:")
                PNoun1 = Console.ReadLine
                Console.WriteLine("Adverb:")
                Adverb1 = Console.ReadLine
                Console.WriteLine("Plural Noun:")
                PNoun2 = Console.ReadLine
                System.Console.WriteLine("Driving a car can be fun if you follow this " & Adj1 & " advice. When approaching a " & Noun1 & " on the right, always check your " & Noun2 &
                                     ". Before making a " & Adj2 & " turn, always stick your " & Noun3 & " out the window. Every 2,000 miles, have your " &
                                     Noun4 & " inspected and your " & Noun5 & " checked. When approaching a school, watch out for " & Adj3 & " " &
                                     PNoun1 & ". Above all, drive " & Adverb1 & ". The " & PNoun2 & " you save may be your own!")
                Console.WriteLine("")
                Console.WriteLine("Restart? Y/N")
                yn = Console.ReadLine
            Loop While yn = "Yes" Or yn = "yes" Or yn = "y" Or yn = "Y"
        End Sub

End Module