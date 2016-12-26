# api-MagicTheGathering

An ASP.NET Core Web Api for returning Magic the Gathering Cards

## This application consists of:

*   A Cards Controller which returns all the documents in the MongoDB cards collection
*   A Card model which maps the fields of a card object, along with related types (Ruling and Legality)

## How to download/clone this project:

*   Navigate to the directory where you want to put this project and run this in the Command Prompt or Terminal:
    ```bash
    $  git clone https://github.com/csharpie/api-magicTheGathering
    ```

## How to initialize this project:

*   cd (change directory) into the directory where you cloned this project
    ```bash
    $  cd api-magicTheGathering/
    ```
*   Run the dotnet project restore command to download all the Nuget packages associated with this API
    ```bash
    $  dotnet restore
    ```

## How to startup this API:

*   Let's start it up!
    ```bash
    $  dotnet run
    ```

## Overview:

*   This is a quick and dirty ASP.NET Core Web API using MongoDB.
*   Some of this code should be refactored and moved into configuration files and business logic classes.
*   Big shoutout to the folks who spent all the time putting Magic the Gathering Card and Set data in JSON format. Visit [MTGJSON.com](http://mtgjson.com)

## Contribute:

*   Please feel free to fork this repository and submit pull requests.
    * First time submitting a Pull Request? Check out [this awesome guide](http://www.codenewbie.org/blogs/how-to-make-a-pull-request)!
