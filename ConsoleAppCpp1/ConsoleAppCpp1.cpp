/*
I want a C++ consele application, it will welcome the user to our application 
and then it will ask first name, then it will ask last name. 
Finally, it will greet with first and last name.
*/

#include <iostream>
#include <string>

int main()
{
    // Welcome message
    std::cout << "Welcome to our application!" << std::endl;

    // Ask for the user's first name
    std::cout << "Please enter your first name: ";
    std::string firstName;
    std::getline(std::cin, firstName);

    // Ask for the user's last name
    std::cout << "Please enter your last name: ";
    std::string lastName;
    std::getline(std::cin, lastName);

    // Greet the user with their full name
    std::cout << "Hello, " << firstName << " " << lastName << "!" << std::endl;

    return 0;
}

