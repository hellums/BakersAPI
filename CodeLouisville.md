## Instructions
To clone and run program on your local system, do the following:

create a new folder, such as "test", then run these commands
- > cd test

- > git clone https://github.com/hellums/bakersapi.git

- > cd bakers

- > dotnet run
- In a browser or tab, enter the URL link listed in the dotnet output followed by /api (https://localhost:7195/api, for example) to see the basic endpoint instructions (/api/ciabatta/600 for 600 grams of ciabatta dough, for example)

- To cleanup when done, return to the command line and press CTRL-C keys to stop the program, then cd back to where you created the test folder and remove it (and ePortfolio) using rmdir /s /q test (on Windows) or rm -rf test (on Mac or Linux)

You can also use Visual Studio to run the tests and program from the IDE by loading the bakers.sln file in that folder, after cloning.
