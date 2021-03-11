#include <unistd.h>
#include <stdlib.h>
#include <stdio.h>
#include <string>



void pipe_out(char* result);

int main(int argc, char* argv[]){
  if ( argv[1] == std::string("--hello") )
    printf("hello i'm your crypto algorithm finder");

  else if ( argv[1]== std::string("-k") )
      pipe_out( argv[2] );

  else if ( argv[1] == std::string("-h") || argv[1] == std::string("--help") )
    printf("manual must be here");

  else {
    printf("nothing to do or you type wrong parameter. Read manual by write -h");
    return EXIT_FAILURE;
    }

    return EXIT_SUCCESS;


}


void pipe_out(char* result){


  fprintf (stdout,result);

}
