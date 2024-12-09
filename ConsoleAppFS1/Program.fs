(*
I want a F# consele application, it will welcome the user to our application 
and then it will ask first name, then it will ask last name. 
Finally, it will greet with first and last name.
*)

open System

[<EntryPoint>]
let main argv =
    // Welcome message
    printfn "Welcome to our application!"

    // Ask for the user's first name
    printf "Please enter your first name: "
    let firstName = Console.ReadLine()

    // Ask for the user's last name
    printf "Please enter your last name: "
    let lastName = Console.ReadLine()

    // Greet the user with their full name
    printfn "Hello, %s %s!" firstName lastName

    0 // return an integer exit code
