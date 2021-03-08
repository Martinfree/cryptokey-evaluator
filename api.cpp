#include "init.h"

/*
Hello, this part of program designed for make api for other parts of my project.
This is universal api for cryptokeys checking.
In this part you may see:
  1. Core structure for different keys;
  2. Sequense of calling preliminary description of callbacks and data structure;

  main function normally call with parametrs place -h to help
*/

void crypto_init(char* i);


int main (int argc, char* argv[]){
    while (argc == 0) return EXIT_FAILURE;

    if ( argv[1] == std::string("--hello") )
      printf("hello i'm your api");

    else if ( argv[1] == std::string("-c") )
      crypto_init(argv[2]);

    else if ( argv[1] == std::string("-h") )
      printf("manual must be here");

    else {
      printf("nothing to do or you type wrong parametr. Read manual by write -h");
      return EXIT_FAILURE;
      }

  return EXIT_SUCCESS;
}

// useless function
void crypto_init(char* i){
  return;
}
