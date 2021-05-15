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
std::string JohnShowFormat(std::string str);
std::string FormatInit(std::string str, const char* erase);

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
        
          
        //crypto_finder(argv[2]);       
    }   
    else if (
        (argv[1] == std::string("-f") || argv[1] == std::string("--find-whoami")) && argv[2]
        ) //find algorithm
    {
        Cypher* CurrentCyph = new Cypher(std::string(argv[2]));
        CurrentCyph->FileWrite(std::string(argv[2]));
        
        AppThread* JohnFind = new AppThread(
            std::string(JOHN).c_str(), 
            std::string(JOHN_SHOW_FORMAT) + std::string(std::string(argv[2])).c_str()
        );
        
        JohnFind->Exec();
        JohnFind->Result = JohnShowFormat(JohnFind->Result);
        delete JohnFind;
        delete CurrentCyph;
    }
    else if (
        (argv[1] == std::string("-fast") || argv[1] == std::string("--fast-check")) && argv[2]       
        ) //find algorithm
    {
        if (
            argv[3]
            ) //if password exist 
        {
            Cypher* CurrentCyph = new Cypher(std::string(argv[2]), std::string(argv[3]));
            
            AppThread* FastCheckSecKey = new AppThread(
                std::string(FINDTIME).c_str(), 
                std::string(std::string("--analyze-pass") + std::string(" ") + std::string(argv[3])).c_str()
            );
           
            AppThread* FastCheckCyph = new AppThread(
                std::string(FINDTIME).c_str(), 
                std::string(std::string("--analyze") + std::string(" ") + std::string(argv[2]) + std::string(" ") + std::string(argv[3])).c_str()
            );
            
            FastCheckSecKey->Exec();
            FastCheckCyph->Exec();
            
            
            
            
            CurrentCyph->Init(argv[2], 
                argv[3],
                std::string("<None>"), 
                std::string("<None>"), 
                FormatInit(
                    FastCheckSecKey->Result, 
                    "Possible combinations: ")
            );
            
            CurrentCyph->ChangeRate(
                1,
                std::stod(FormatInit(  
                    FastCheckSecKey->Result,
                    "Total mark for password: "))  
            );
            delete CurrentCyph;
        }
        else
        {
            Cypher* CurrentCyph = new Cypher(std::string(argv[2]));
             
            AppThread* FastCheckCyph = new AppThread(
                std::string(FINDTIME).c_str(), 
                std::string(std::string("--analyze") + std::string(" ") + std::string(argv[2])).c_str()
            );
            
            FastCheckCyph->Exec();
            delete CurrentCyph;
        }

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

std::string JohnShowFormat(std::string str) 
{
    std::string res = "Possible algorithms: \n";
    
    if (str.find("gost", 0)!= 0) res += std::string("gost\n");
    
    if (str.find("SHA256", 0 != 0)) res += std::string("sha256\n");
    
    return res;
}

std::string FormatInit(std::string str, const char* erase)
{
    
    char res[1024];
    //str.copy(buffer2, FastCheckSecKey->Result.find("SecKeyCombination:"), strlen("Possible combinations: ")
    
    //printf("\n\n\n\n\n%s", str.c_str());
    str.copy(res, str.find(";", str.find(erase)) - str.find(erase)- strlen(erase) , str.find(erase)+ strlen(erase));
    
    return std::string(res);
}
