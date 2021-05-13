#include <unistd.h>
#include <stdlib.h>
#include <stdio.h>
#include <string>
#include <iostream>
#include <fstream>


//
// Program for search password in wordlist
//

void pipe_out(std::string result);
std::string FastCheckShow(std::string str, std::ifstream& wordlist);

int main(int argc, char* argv[]) {
    if (
        argv[1] == std::string("--hello")
        )
        printf("hello i'm your searcher");

    else if (
        (argv[1] == std::string("-s") || argv[1] == std::string("--single")) && argv[2]
        ) // dafult wordlists
    {
        std::ifstream file("include/rockyou.txt", std::ifstream::in);
        pipe_out(FastCheckShow(std::string(argv[2]), file));
        file.close();
    }
    else if (
        argv[1] == std::string("-f") || argv[2]
        ) // send to me wordlist file 
        pipe_out(argv[2]);

    else if (
        argv[1] == std::string("-h") || argv[1] == std::string("--help")
        )
        printf("manual must be here");

    else {
        printf("nothing to do or you type wrong parameter. Read manual by write -h");
        return EXIT_FAILURE;
    }

    return EXIT_SUCCESS;


}


void pipe_out(std::string result) {


    fprintf(stdout, result.c_str());

}

std::string FastCheckShow(std::string str, std::ifstream& wordlist)
{
    std::string line;
    for (unsigned int curLine = 0; std::getline(wordlist, line); curLine++) {
        if (line.find(str) != std::string::npos) {
            str = std::string("found: ") + str + std::string(" in file: <NONE>");
            return str;
        }
    }
    return "ERROR";
}