'I want a VB consele application, it will welcome the user to our application 
'And then it will ask first name, then it will ask last name. 
'Finally, it will greet With first And last name.

Module Program
    Sub Main()
        ' Kullanıcıya hoş geldiniz mesajı yazdırıyoruz
        Console.WriteLine("Welcome to our application!")

        ' Kullanıcıdan ilk adını girmesini istiyoruz ve firstName değişkenine atıyoruz
        Console.Write("Please enter your first name: ")
        Dim firstName As String = Console.ReadLine()

        ' Kullanıcıdan soyadını girmesini istiyoruz ve lastName değişkenine atıyoruz
        Console.Write("Please enter your last name: ")
        Dim lastName As String = Console.ReadLine()

        ' Kullanıcıyı tam adıyla selamlıyoruz
        Console.WriteLine($"Hello, {firstName} {lastName}!")
    End Sub
End Module
