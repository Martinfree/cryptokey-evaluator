#include <stdlib.h>
#include <stdio.h>
#include <string>
#include <thread>
#include "crypto.h"


#define THREADS std::thread::hardware_concurrency()
FILE  *Pcrypto_finder;

/*This file for headers and data initialize*/
