# BakersAPI

## This [Baker's Percentage API](https://hellums-bakersapi.azurewebsites.net/api) returns the ingredients (in grams) for common bread types, based on desired total dough needed.

Parameters for bread type and weight are passed to the API in the following format:

https://hellums-bakersapi.azurewebsites.net/api 

Instructions: After /api in URL add bread type and weight in grams, for example: /api/ciabatta/900 (other types: sandwich, focaccia, french, pizza, rolls, buns, or dumplings; weight is in grams)

For example, to see ingredients needed for 575 grams of white sandwich loaf (one pan):

[https://hellums-bakersapi.azurewebsites.net/api/sandwich/575](https://hellums-bakersapi.azurewebsites.net/api/sandwich/575)

To see ingredients needed for 680 grams of pizza dough (2 x 12" crusts, 1 oz or 28.35 grams per inch of total diameter):

[https://hellums-bakersapi.azurewebsites.net/api/pizza/680](https://hellums-bakersapi.azurewebsites.net/api/pizza/680)

To see ingredients needed for 900 grams of ciabatta (2 typical loaves):

[https://hellums-bakersapi.azurewebsites.net/api/ciabatta/900](https://hellums-bakersapi.azurewebsites.net/api/ciabatta/900)

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
