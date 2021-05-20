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
void FileWrite(std::string cyph);
void CallCmd(std::string argv1);
void CallCmd(std::string argv1, std::string argv2);
void CallCmd(std::string argv1, std::string argv2, std::string argv3);

std::string JohnShowFormat(std::string str);
std::string FormatInit(std::string str, const char* erase);
std::string FindPass(std::string file, std::string secret);
int main (int argc, char* argv[]){
    
    
    switch (argc)
    {
    case 0:
        return EXIT_FAILURE;
    }
    

    if (!argv[2]) CallCmd(std::string(argv[1]));
    
    if (!argv[3]) CallCmd(std::string(argv[1]), std::string(std::string(argv[2])));
    
    if (argv[3])CallCmd(std::string(argv[1]), std::string(std::string(argv[2])), std::string(std::string(argv[3])));

  return EXIT_SUCCESS; 
}


void CallCmd(std::string argv1)
{
    if (
        argv1 == "--hello"
        ){
        printf("hello i'm your api you can read manual by -h option");
        
    }
    else if (
        argv1 == "-h" || argv1 == "--help"
        ) printf("No manual now");
    else {
        printf("nothing to do or you type wrong parameter. Read manual by write -h");
        
            
    }

}

void CallCmd(std::string argv1, std::string argv2)
{

    if (
        argv1 == "--find-whoami"
        ) {
        //Cypher* CurrentCyph = new Cypher(std::string(std::string(argv2)));
        //CurrentCyph->FileWrite(std::string(std::string(argv2)));
        FileWrite(std::string(std::string(argv2)));

        AppThread* JohnFind = new AppThread(
            std::string(JOHN).c_str(),
            std::string(JOHN_SHOW_FORMAT) + std::string(std::string(std::string(argv2))).c_str()
        );

        JohnFind->Exec();
        JohnFind->Result = JohnShowFormat(JohnFind->Result);
        delete JohnFind;
        //delete CurrentCyph;
    }
    else if (
        std::string(argv1).find("--fast-check-format=") != std::string::npos
        ) {// fast check secret text 
        printf("I didn't know how to analyze %s",
            std::string(argv1).substr(std::string(argv1).find("--fast-check-format=") + std::string("--fast-check-format=").length()).c_str()
        );

    }
    else if (
        std::string(argv1).find("--find-pass=") != std::string::npos
        ) printf("%s",
            FindPass(std::string(argv1).substr(std::string(argv1).find("--find-pass=") + std::string("--find-pass=").length()).c_str(),
                std::string(argv2)).c_str()
        );
    else if (
        (std::string(argv1).find("--find-pass") != std::string::npos)
        ) printf("%s",
                FindPass(std::string("include/rockyou.txt"),
                    std::string(argv2)).c_str());
    

}

void CallCmd(std::string argv1, std::string argv2, std::string argv3)
{

    if (
        argv1 == "--fast-check" //simple check password
        ) {
        Cypher* CurrentCyph = new Cypher(
            std::string(std::string(argv2)), 
            std::string(std::string(argv3))
        );
        
        CurrentCyph->AnalyzePass(argv3);

        CurrentCyph->InitRes(std::string(argv2),
            std::string(argv3),
            std::string("<None>"),
            std::string("<None>")
        );
        
        CurrentCyph->ChangeRate(-1,-1);
        delete CurrentCyph;
    }
}


void InitApp(char* app, char* args) {
    printf("i useless now");
}


std::string JohnShowFormat(std::string str) 
{
    std::string res = "Possible algorithms: \n";
    
    size_t pos=0;
    while (pos != -1)
    {
        pos = str.find("{\"label\":", pos);
        if (pos == -1)
        {
        }
        else
        {
            char* alg = new char[16];
            
            str.copy(alg, str.find("\",\"", pos) - str.find("{\"label\":", pos) - strlen("{\"label\":") - 1, str.find("{\"label\":", pos) + strlen("{\"label\":") + 1);
            alg[str.find("\",\"", pos) - str.find("{\"label\":", pos) - strlen("{\"label\":")-1] = '\0';
            res = res + std::string(alg) + std::string("; \n");
            pos += strlen("{\"label\":");
            alg[64] = '\0';
            delete[] alg;
        }
    }

    
    return res;
}


std::string FormatInit(std::string str, const char* erase)
{
    
    char res[1024];
    str.copy(res, str.find(";", str.find(erase)) - str.find(erase)- strlen(erase)-1 , str.find(erase)+ strlen(erase));
    
    return std::string(res);
}

std::string FindPass(std::string file_name, std::string secret)
{
    char path[256];
    getcwd(path, 256);
    std::ifstream file((std::string(path) + std::string("/") + std::string(file_name)).c_str(), std::ifstream::in);
    //std::ifstream file(file_name, std::ifstream::in);
    if (
        file.is_open()
        ) {
        std::string line;
        for (unsigned int curLine = 0; std::getline(file, line); curLine++) {
            if (line.find(secret) != std::string::npos) {
                secret = std::string("found: ") + secret + std::string(" in file: ") + file_name;
                return secret;
            }
        }
        file.close();
    } else return std::string(std::string("No such file or dir: ") + (std::string(path) + std::string("/") + std::string(file_name)));

    return "Error";
}

//write hash to file for JohnTheRipper, Hascat and other progs
void FileWrite(std::string cyph) {

    CyphFile = fopen(cyph.c_str(), "wa+");
    fprintf(CyphFile, cyph.c_str());
    fclose(CyphFile);
}