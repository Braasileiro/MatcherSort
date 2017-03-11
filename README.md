# MatcherSort
A program to organize two identical files but with their contents in different order.

I created this program initially to organize some files of the translation of the game Saints Row: The Third because the new format of extraction of the strings is different from the old one and the old files had the numbering of lines different from the new one, but with the identical content.

I realized that this tool can be very useful in remote scripts where it does not need to be inside the user's machine and so always check if the file has not changed, at least its contents. The source code is there and you can adapt it for your purpose, I put 2 basic functions as it was what I needed to help me in the translation of the game as I mentioned above.

# Installing
The program has no installer, just open the executable "MatcherSort.exe" and follow the instructions.

# Requeriments
* Windows 7 or higher
* Microsoft .NET Framework 4.5.2

# Usage
#### IMPORTANT NOTE: The input files must be encoded in UTF-8.

The program has 2 programmed operating modes:

### 1. Target File Organizer
In this mode you enter a template file and a file that you want to organize by template.

Example:

**defaultFile.txt**
```
1    Lucas
2    Is
3    The
4    Best
```

**targetedFile.txt**
```
1    Is
2    Lucas
3    Best
4    The
```

Output **_streamed-targetedFile.txt**
```
1    Lucas
2    Is
3    The
4    Best
```

It basically organizes the file according to the template.

### 1. Target File Line on Other File
That way a little more complex to understand.

In this mode you enter a template file, the file you want to organize according to the template, and a file that contains the same number of lines of the file that will be organized, but with for example a different language.

Example, in the file that you want to organize there is a string written **`LoadMethods()`** in English and in the same line as the secondary file the string is written as **`CarregarMetodos()`** which is in Brazilian Portuguese.

That way it would work like this:

**defaultFile.txt**
```
1    KickAllNoobs()
2    BanUsersThatPostPoorMemes()
3    GithubIsLove()
4    ShrekIsLife()
```

**targetedFile.txt**
```
1    BanUsersThatPostPoorMemes()
2    KickAllNoobs()
3    ShrekIsLife()
4    GithubIsLove()
```

**secondaryFile.txt** (same row count and content of **targetedFile.txt**, but this rows is in Brazilian Portuguese)
```
1    BanirUsuariosQuePostamMemesRuins()
2    ExpulsarTodosNovatos()
3    ShrekEVida()
4    GithubEAmor()
```

Output **_streamed-secondaryFile.txt**
```
1    ExpulsarTodosNovatos()
2    BanirUsuariosQuePostamMemesRuins()
3    GithubEAmor()
4    ShrekEVida()
```

Basically the algorithm takes the line number from **"targetedFile.txt"** and copies the contents of the line from the **"secondaryFile.txt"** file automatically to conform to the template file.

In my case it was very useful because I had the template file in the right order, the English file in the wrong order and the Brazilian Portuguese file in the same order as the English file, but with its translated content and consequently different strings. This mode is based on the line number and not the string content.

# WARNING
This program can be **VERY USELESS** for some people! :)

It has a very specific function, but it costs nothing to share with the world, can it be that someone has the same problem as me?

In addition to that the code is there to be adapted and readapted as many times as you want, but do not forget to leave the due credits or I will call Shrek for you!
