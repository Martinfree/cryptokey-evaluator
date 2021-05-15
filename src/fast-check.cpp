#include <unistd.h>
#include <stdlib.h>
#include <stdio.h>
#include <cmath>
#include <string>
#include <iostream>
#include <iomanip> 
#include <sstream>
#include <fstream>



//
// Program for search password in wordlist and calculate time to hack
//

void pipe_out(std::string result);
std::string FastCheckShowPass(std::string str, std::ifstream& wordlist, std::string file_name);
std::string AnalyzePass(std::string str);
std::string AnalyzeSecText(std::string str);

int main(int argc, char* argv[]) {
    if (
        argv[1] == std::string("--hello")
        )
        printf("hello i'm your searcher");

    else if (
        (argv[1] == std::string("-s") || argv[1] == std::string("--single")) && argv[2]
        ) // default wordlists
    {
        char path[256];
        getcwd(path, 256);
        std::ifstream file("include/rockyou.txt", std::ifstream::in);
        pipe_out(FastCheckShowPass(std::string(argv[2]), file, std::string(path) + std::string("/") + std::string(argv[2])));
        file.close();
    }
    else if (
        argv[1] == std::string("-f") && argv[2] && argv[3]
        ) // send to me where wordlist file 
    {
        char path[256];
        getcwd(path, 256);
        std::ifstream file((std::string(path) + std::string("/") + std::string(argv[2])).c_str(), std::ifstream::in);
        if (
            file.is_open()
            )
            pipe_out(FastCheckShowPass(std::string(argv[3]), file, std::string(path) + std::string("/") + std::string(argv[2])));

        else
            printf("No such file or dir:\n", (std::string(path) + std::string("/") + std::string(argv[2])).c_str());
    }
    else if (
        (argv[1] == std::string("--analyze-pass")) && argv[2]
        )// analyze password
    {
        pipe_out(AnalyzePass(argv[2]));
    }
    else if (
        argv[1] == std::string("-a") || argv[1] == std::string("--analyze") && argv[2]
        )// analyze only secret text (second arg is posiible algorithm)
    {
        
        pipe_out(AnalyzeSecText(argv[2]));
    }
        
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

std::string FastCheckShowPass(std::string str, std::ifstream& wordlist, std::string file_name)
{
    std::string line;
    for (unsigned int curLine = 0; std::getline(wordlist, line); curLine++) {
        if (line.find(str) != std::string::npos) {
            str = std::string("found: ") + str + std::string(" in file: ") + file_name;
            return str;
        }
    }
    return "Password Not found in files";
}


std::string AnalyzePass(std::string str)
{
    int upper = 0, lower = 0, number = 0, special = 0;
    long double comb = 0.0;
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] >= 'A' && str[i] <= 'Z')
            upper++;
        else if (str[i] >= 'a' && str[i] <= 'z')
            lower++;
        else if (str[i] >= '0' && str[i] <= '9')
            number++;
        else
            special++;
    }
    
    
    if (
        (number != 0) && (upper+ lower+ special == 0)
        )
        comb = pow(10, str.length());
    
    else if (
        (lower != 0 && upper+ number+ special == 0) || (upper != 0 && lower+ number+ special == 0)
        )
        comb = pow(26, str.length());
   
    else if (
        (number, lower != 0 && special+ upper == 0) || (number, upper != 0 && special+ lower == 0)
        )
        comb = pow(36, str.length());

    else if (
        (upper != 0 && lower != 0) && (number+ special == 0)
        )
        comb = pow(52, str.length());
    
    else if (
        number != 0 && upper != 0 && lower != 0 && special == 0
        )
        comb = pow(62, str.length());

    else if (
        special != 0 && lower != 0 && upper != 0 && number == 0
        )
        comb = pow(84, str.length());
    
    else if (
        number != 0 && lower != 0 && upper != 0 && special != 0
        )
        comb = pow(94, str.length());

    else comb = pow(32, str.length());
    
    std::stringstream result;
    result << std::string("Password length: ") << std::fixed << std::setprecision(0) << str.length() << std::string(" ")
        << std::string("Uppercase: ") << upper << std::string("; ")
        << std::string("Lowercase: ") << lower << std::string("; ")
        << std::string("Numbers: ") << number << std::string("; ")
        << std::string("Special: ") << special << std::string("; ")
        << std::string("Possible combinations: ") << comb << std::string("; ")
    << std::string("Total mark for password: ") << (upper*2 + lower + number + special*3)*3.5 << std::string("; ");
    return result.str();
}

std::string AnalyzeSecText(std::string str)
{
    
    return "No";
}