//      PASSWORD CREATOR
//  This basic code can help suggest a password to the user by replacing some characters
//  with speciall characters. It can be made more complex by changing the position of 
//  the non-special characters as well as changing some lowercases to uppercase.
var input = Console.ReadLine();

for (int i = 0; i < input.Length; ++i)
{
    switch (char.ToLower(input[i]))
    {
        case 'a':
            Console.Write('/');
            break;

        case 'f':
            Console.Write('!');
            break;

        case 'g':
            Console.Write('@');
            break;

        case 't':
            Console.Write('#');
            break;

        case 'h':
            Console.Write('$');
            break;

        case 'y':
            Console.Write('%');
            break;

        case 'b':
            Console.Write('^');
            break;

        default:
            Console.Write(input[i]);
            break;
    }
}

Console.ReadLine();

