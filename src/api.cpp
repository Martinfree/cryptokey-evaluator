#include "init.h"

/*
Hello, this part of program designed for make api for other parts of my project.
This is universal api for cryptokeys checking.
In this part you may see:
  1. Core structure for different keys;
  2. Sequense of calling preliminary description of callbacks and data structure;

  main function normally call with parametrs place -h to help
*/

void InitApp(char *app, char* args);


int main (int argc, char* argv[]){
    while (argc == 0) return EXIT_FAILURE;

    if (
        argv[1] == std::string("--hello") || argv[1] == std::string("--help")
        )
    {
        printf("hello i'm your api you can read manual by -h option");
    }

    else if (
        argv[1] == std::string("--test") && argv[2]
        ) //test some features
    {
        //TEST
        //AppThread FindExe(std::string("find.exe ").c_str(), std::string("-k " + std::string(argv[2])).c_str());
        //FindExe.FormatStr();
        //crypto_finder(argv[2]); 
    }  
    else if (
        (argv[1] == std::string("-f") || argv[1] == std::string("--find-whoami")) && argv[2]
        ) //find algorithm
    {
        printf("i don't know now");
    }
    else if (
        (argv[1] == std::string("-fast") || argv[1] == std::string("--fast-check")) && argv[2]
        ) //find algorithm
    {
        printf("fast check");
    }

    else if (
        argv[1] == std::string("-h")
        )
    {
        printf("manual must be here");
    }

    else {
      printf("nothing to do or you type wrong parameter. Read manual by write -h");
      return EXIT_FAILURE;
      }

  return EXIT_SUCCESS;
}

void InitApp(char* app, char* args) {
    printf("i useless now");
}