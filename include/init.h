

#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <string>
#include <thread>
#include <vector>
#include <cstring>

#define THREADS std::thread::hardware_concurrency()
#define MAXIMUM_BUFFER 65536
#define JOHN "powershell john "
#define FINDTIME "fast-check "
#define JOHN_SHOW_FORMAT "--show=formats "
FILE* Pcrypto_finder;

#include "crypto.h"



/*This file for headers and data initialize*/
