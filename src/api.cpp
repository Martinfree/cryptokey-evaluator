#include "init.h"

/*
Hello, this part of program designed for make api for other parts of my project.
This is universal api for cryptokeys checking.
In this part you may see:
  1. Core structure for different keys;
  2. Sequense of calling preliminary description of callbacks and data structure;

  main function normally call with parametrs place -h to help
*/

// Custom functions
std::string JohnShowFormat(std::string str);
std::string FormatInit(std::string str, const char* erase);
std::string FindInFilePass(std::string file_name, std::string secret);
std::ifstream OpenFile(std::string file_name);
std::string FindStr(std::string file);

//constexpr-like
std::string format_equal(std::string str, const char* line);

// call functions

//hello cmd
void SayHello(char* argv[]); 

// manual for prog
void PrintManual(char* argv[]); 

//fast check cypher text
void FastCheckFormat(char* argv[]); 

//find pass in rockyou
void FindPass(char* argv[]);

void InitApp(char *app, char* args); 
// show possible formats
std::string FindWhoAmI(const char* argv);
// fast check password
void FastCheck(char* argv[]); 
// try dictionary attack
void DictAttack(char* argv[]); 
// try mask attack
void MaskAttack(char* argv[]); 
// try brute-froce attack
void BruteForceAttack(char* argv[]); 
// analyze all data
void CrackingResistance(char* argv[]); 

bool StrInCmd(std::string cmd, const char* line);



int main (int argc, char* argv[]){
    
    char basePath[255] = "";
    _fullpath(basePath, argv[0], sizeof(basePath));
    
    switch (argc)
    {
    case 0:
        return EXIT_FAILURE;
    }
    
    if (
        argv[1] == "--hello"
        ) SayHello(argv);

    else if (
        argv[1] == "-h" || argv[1] == "--help"
        ) PrintManual(argv);

    else if (
        StrInCmd(argv[1],"--find-whoami=")// && argv[2]
        ) {
            
        printf(FindWhoAmI(format_equal(argv[1], "--find-whoami=").c_str()).c_str());
    }

    else if (
        StrInCmd(argv[1],"--fast-check-format=")
        ) FastCheckFormat(argv);

    else if (
        StrInCmd(argv[1], "--find-pass=")
        ) printf("%s.\n", FindInFilePass(
                std::string(argv[0]).replace(std::string(argv[0]).find("api.exe"), std::string("api.exe").length(), std::string("")).c_str() + std::string("include/rockyou.txt"),
                format_equal(argv[1], "--find-pass=") ).c_str()
        );

//    else if (
//        argv[2]
//        ) 
//        FindPass(std::string("include/rockyou.txt"), argv[2]);

    else if (
        StrInCmd(argv[1], "--fast-check")
        ) FastCheck(argv);

    else if (
        StrInCmd(argv[1], "--dict-attack=")
        ) DictAttack(argv);

    else if (
        StrInCmd(argv[1], "--mask-attack=")
        ) MaskAttack(argv);
    else if (
        StrInCmd(argv[1], "--brute-force-attack")
        ) BruteForceAttack(argv);

    else if (
        StrInCmd(argv[1], "--cracking-resistance")
        ) CrackingResistance(argv);
    
    else printf("nothing to do or you type wrong parameter. Read manual by write -h");
  return EXIT_SUCCESS; 
}

void SayHello(char* argv[])
{
    printf("hello i'm your api you can read manual by -h option\n");
}


void PrintManual(char* argv[])
{
    printf("No manual now");
}


std::string FindWhoAmI(const char* argv)
{
    std::ifstream file = OpenFile(
        std::string(argv)
    );
    if (
        file.is_open()
        ) {
        file.close();
    } else printf("No such file or dir");
        AppThread* JohnFind = new AppThread(
            std::string(JOHN).c_str(),
            std::string(JOHN_SHOW_FORMAT) + std::string(std::string(std::string(argv))).c_str()
        );

        JohnFind->Exec();
        JohnFind->Result = JohnShowFormat(JohnFind->Result);
        //printf("%s", JohnFind->Result.c_str());
        return JohnFind->Result;
    
}
 
void FastCheckFormat(char* argv[])
{
    printf("I didn't know how to analyze %s",
        format_equal(argv[1], "--fast-check-format=")
    );
}

void FindPass(char* argv[])
{
    printf("%s",
        FindInFilePass(std::string("include/rockyou.txt"),
            format_equal(argv[1], "--find-pass=")
        ));
}

void FastCheck(char* argv[])
{
    Cypher* CurrentCyph;
    std::string line;
    std::ifstream file = OpenFile(argv[2]);

    if (
        file.is_open()
        ) {

        for (unsigned int curLine = 0; std::getline(file, line); curLine++) {

            CurrentCyph = new Cypher(
                line,
                argv[3]
            );
            //secret = std::string("found: ") + secret + std::string(" in file: ") + file_name;
            CurrentCyph->AnalyzePass(argv[3]);

            CurrentCyph->InitRes(line,
                std::string(argv[3]),
                std::string("<None>")
            );

            CurrentCyph->ChangeRate(-1, -1);
            delete CurrentCyph;
        }

    }
    else printf("No such file");
    file.close();
}

void DictAttack(char* argv[])
{

    std::ifstream file = OpenFile(
        format_equal(argv[1], "--dict-attack=")
    );
    if (
        file.is_open()
        ) {

        //Cypher* CurrentCyph = new Cypher(
        //    std::string(std::string(argv[2])),
        //    std::string(std::string(argv[3]))
        //);


        AppThread* DictAttack = new AppThread(
            std::string(JOHN).c_str(),
            std::string(JOHN_FORMAT) + argv[3] + std::string(" ") + std::string(JOHN_DICT_ATTACK) + format_equal(argv[1], "--dict-attack=") + std::string(" ") + argv[2]
        );
        DictAttack->Exec();

        //delete DictAttack;
        AppThread* DictAttackRes = new AppThread(
            std::string(JOHN).c_str(),
            std::string(JOHN_SHOW) + std::string(" ") + argv[2]
        );

        //printf("\n%s\n", (std::string(JOHN_DICT_ATTACK) + format_equal(argv[1], "--dict-attack=") + argv[2]).c_str());
        DictAttackRes->Exec();
        printf("%s", DictAttackRes->Result.c_str());
    }
}

void MaskAttack(char* argv[])
{
    //Hashcat hashcat.bat -D 2 -m 16500 -a 3 C:\cryptokey-evaluator\main\cryptokey-evaluator\hash.txt qwerty?d?d?d?d?d
    //Hashcat hashcat.bat -D 2 -m 16500 -a 3 --show C:\cryptokey-evaluator\main\cryptokey-evaluator\hash.txt qwerty?d?d?d?d?d

    AppThread* MaskAttack = new AppThread(
        std::string(JOHN).c_str(),
        std::string(JOHN_FORMAT) + argv[3] + std::string(" ") + std::string(JOHN_MASK_ATTACK) + format_equal(argv[1], "--mask-attack=") + std::string(" ") + argv[2]
    );
    MaskAttack->Exec();

    //delete DictAttack;
    AppThread* MaskAttackRes = new AppThread(
        std::string(JOHN).c_str(),
        std::string(JOHN_SHOW) + std::string(" ") + argv[2]
    );

    //printf("\n%s\n", (std::string(JOHN_DICT_ATTACK) + format_equal(argv[1], "--dict-attack=") + argv[2]).c_str());
    MaskAttackRes->Exec();
    printf("%s", MaskAttackRes->Result.c_str());
}

void BruteForceAttack(char* argv[])
{
    //Hashcat hashcat.bat -D 2 -m 16500 -a 3 C:\cryptokey-evaluator\main\cryptokey-evaluator\hash.txt qwerty?d?d?d?d?d
    //Hashcat hashcat.bat -D 2 -m 16500 -a 3 --show C:\cryptokey-evaluator\main\cryptokey-evaluator\hash.txt qwerty?d?d?d?d?d

    AppThread* MaskAttack = new AppThread(
        std::string(JOHN).c_str(),
        std::string(JOHN_FORMAT) + argv[3] + std::string(" ") + std::string(" ") + argv[2]
    );
    MaskAttack->Exec();

    //delete DictAttack;
    AppThread* MaskAttackRes = new AppThread(
        std::string(JOHN).c_str(),
        std::string(JOHN_SHOW) + std::string(" ") + argv[2]
    );

    //printf("\n%s\n", (std::string(JOHN_DICT_ATTACK) + format_equal(argv[1], "--dict-attack=") + argv[2]).c_str());
    MaskAttackRes->Exec();
    printf("%s", MaskAttackRes->Result.c_str());
}

void CrackingResistance(char* argv[])
{
    // We need to analyze all the positions: 
    // Cypher text - analyze: length, frequency analysis, find format (optional)
    // Secret key (optional) - analyze key(mark for characters), time to crack possibility to find in
    // Complex mark and posibility to attack with extended methods 
    std::string hash, format, secret = "";

    if (
        StrInCmd(argv[2], "--hash-file=")
        ) {
        hash = format_equal(argv[2], "--hash-file=");
        hash = FindStr(hash);
    }
    if (
        StrInCmd(argv[3], "--format=")
        ) {
        format = format_equal(std::string(argv[3]), "--format=");
    }
    if (
        StrInCmd(argv[4], "--secret=")
        ) {
        secret = format_equal(std::string(argv[4]), "--secret=");
    }
    if (
        StrInCmd(argv[4], "--secret-file=")
        ) {
        secret = format_equal(std::string(argv[4]), "--secret-file=");
        secret = FindStr(secret);
    }
    Cypher* CurrentCyph = new Cypher(hash, secret, format);
    
    
    CurrentCyph->CalculateHash();
    CurrentCyph->AnalyzeCyph(hash, true);
    CurrentCyph->AnalyzePass(secret);
    if ( 
        !StrInCmd(
            FindWhoAmI(format_equal(argv[2], "--hash-file=").c_str()), format.c_str()
        )
        ) CurrentCyph->ChangeRate(0, 40);
    
    delete CurrentCyph;
}

bool StrInCmd(std::string cmd, const char* line)
{
    return std::string(std::string(cmd)).find(line) != std::string::npos;
}

std::string format_equal(std::string str, const char* line)
{
    return str.substr(std::string(str).find(line) + std::string(line).length());
}

void InitApp(char* app, char* args) {
    printf("i useless now");
}

 
std::string JohnShowFormat(std::string str) 
{
    std::string res = "Possible algorithms: \n";
    
    size_t pos=0;
    while (
        pos != -1
        ) {
        pos = str.find("{\"label\":", pos);
        if (
            pos == -1
            ) {
        }
        else {
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

std::string FindStr(std::string file_name)
{
    std::ifstream file = OpenFile(file_name);
    std::string line;
    if (
        file.is_open()
        ) {
        for (unsigned int curLine = 0; std::getline(file, line); curLine++) return line;
        file.close();
    } else return std::string(std::string("No such file or dir "));
    return std::string("");
}

std::string FindInFilePass(std::string file_name, std::string secret)
{
    
    //std::ifstream file(file_name, std::ifstream::in);
    //std::ifstream file = OpenFile(file_name);
    std::ifstream file(file_name, std::ifstream::in);
    if (
        file.is_open()
        ) {
        std::string line;
        for (
            unsigned int curLine = 0; std::getline(file, line); curLine++
            ) {
            if (
                line.find(secret) != std::string::npos && line.length() == secret.length()
                ) {
                secret = std::string("found: ") + secret + std::string(" in file: ") + file_name;
                return secret;
            }
        }
        file.close();
    }
    else return std::string(std::string("No such file or dir ") );
    return std::string("");
}

//write hash to file for JohnTheRipper, Hascat and other progs
void CreateFile(std::string cyph) {

    CyphFile = fopen(cyph.c_str(), "wa+");
    fprintf(CyphFile, cyph.c_str());
    fclose(CyphFile);
}

std::ifstream OpenFile(std::string file_name)
{
    char path[256];
    getcwd(path, 256);
    std::ifstream file(std::string(file_name).c_str(), std::ifstream::in);
    return file;
} 