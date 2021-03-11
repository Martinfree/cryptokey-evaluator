#include "init.h"

/*
Hello, this part of program designed for make api for other parts of my project.
This is universal api for cryptokeys checking.
In this part you may see:
  1. Core structure for different keys;
  2. Sequense of calling preliminary description of callbacks and data structure;

  main function normally call with parametrs place -h to help
*/

int crypto_finder(char* i);


int main (int argc, char* argv[]){
    while (argc == 0) return EXIT_FAILURE;

    if ( argv[1] == std::string("--hello") || argv[1] == std::string("--help") )
      printf("hello i'm your api");

    else if ( argv[1] == std::string("-c") )
      crypto_finder(argv[2]);

    else if ( argv[1] == std::string("-h") )
      printf("manual must be here");

    else {
      printf("nothing to do or you type wrong parameter. Read manual by write -h");
      return EXIT_FAILURE;
      }

  return EXIT_SUCCESS;
}

// useless function
int crypto_finder(char* i){

  std::string call_buffer = "find.exe -k ";
  call_buffer += std::string(i);

  if ( (Pcrypto_finder = popen( call_buffer.c_str(),"r")) == NULL )
    return EXIT_FAILURE;

  else{

    std::string result = "";
    char* buffer = new char [MAXIMUM_BUFFER];
     // use buffer to read and add to result
     while(fgets(buffer,MAXIMUM_BUFFER,Pcrypto_finder)){
       puts(buffer);
      }
      pclose(Pcrypto_finder);

      delete buffer;

  return EXIT_SUCCESS;
}
}
