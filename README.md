# AppClient

## Description

This application was developed in the course [Fundamentos C#](https://desenvolvedor.io/curso-online-fundamentos-do-csharp) on the platform [desenvolvedor.io](https://desenvolvedor.io).

The project consists of developing a console-type application in C# to simulate client registration. It offers functionalities to create, view, update and delete client information.

The application stores client data in memory or in a TXT file.

## Dependencies

Before running the application, make sure you have the following installed on your machine:

- Visual Studio Community or VS Code with C# development support.
- .NET Core SDK

## Get started the app

1. Clone or download the repository to your local machine.
2. Open the project in Visual Studio or VS Code.
3. Compile and run the project.

```shell
dotnet clean
dotnet restore
dotnet build
```

## Functionalities

### 0. Main Menu

```shell
--------------------------------------------------
Client Registration
--------------------------------------------------
1 - Create a client
2 - Show all clients
3 - Edit a client
4 - Delete a client
5 - Exit
Choose one of the options above:
```

### 1. Create a client

Allows the user to register a new client by providing information such as name, date of birth, discount amount.

```shell
Name: # John Doe

Discount value: # 10,0

Birth date: # 09/09/2000

ID............: 1
Name..........: John Doe
Discount value: 10,0
Birth date....: 09/09/2000
Created at....: 02/10/2023 10:29:32
---------------------------------------------------
Press <ENTER> to continue...
```

### 2. Show all clients

Displays a list of all clients registered in the application.

```shell
ID............: 1
Name..........: John Doe
Discount value: 10.0
Birth date....: 09/09/2000
Created at....: 02/10/2023 10:29:32
---------------------------------------------------
Press <ENTER> to continue...
```

### 3. Edit a client

Allows the user to update an existing client's information by ID.

```shell
Enter the clients ID: 1
ID............: 1
Name..........: John Doe
Discount value: 10,00
Birth date....: 09/09/2000
Created at....: 02/10/2023 10:29:32
---------------------------------------------------
Name: #John Doe

Discount value: # 12,0

Birth date: # 01/01/2000

Client updated successful! Press <ENTER> to continue...
ID............: 1
Name..........: John Doe
Discount value: 12,00
Birth date....: 01/01/2000
Created at....: 02/10/2023 10:29:32
---------------------------------------------------
```

### 4. Delete a client

Allows the user to delete a client by ID.

```shell
Enter the clients ID: # 1
Client deleted successful! Press <ENTER> to continue...
```

### 5. Exit

Closes the application.

```shell
--------------------------------------------------
Client Registration
--------------------------------------------------
1 - Create a client
2 - Show all clients
3 - Edit a client
4 - Delete a client
5 - Exit
Choose one of the options above:
# 5
Finishing the program. Press <ENTER> to close...
```

## Contribution

If you would like to contribute to the development of this application, feel free to create a pull request in the repository and follow the contribution guidelines.

## License

This project is licensed under the MIT License. See the LICENSE file for more information.Este projeto está licenciado sob a Licença MIT. Consulte o arquivo LICENSE para obter mais informações.

## Contact me

Send an email to [gubsocosta@gmail.com](mailto:gubsocosta@gmail.com) or send a message to [discord](https://discordapp.com/channels/@me/gubsocosta#6826/)
