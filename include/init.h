

#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <cmath>
#include <string>
#include <iomanip> 
#include <iostream>
#include <sstream>
#include <fstream>
#include <string>
#include <thread>
#include <vector>
#include <cstring>


#define THREADS std::thread::hardware_concurrency()
#define MAXIMUM_BUFFER 65536

// john available cmds
#define JOHN "powershell john "
#define JOHN_SHOW "--show"
#define JOHN_SHOW_FORMAT "--show=formats "
#define JOHN_FORMAT "--format="
#define JOHN_DICT_ATTACK "--wordlist="
#define JOHN_MASK_ATTACK "--mask="

// hashcat available cmds
#define HC "powershell hashcat "
#define HC_FORMAT "--format="
#define HC_DICT_ATTACK "wordlist="
#define HC_MASK_ATTACK "--mask="

FILE* Pcrypto_finder;
FILE* CyphFile;
#include "crypto.h"



/*This file for headers and data initialize*/
