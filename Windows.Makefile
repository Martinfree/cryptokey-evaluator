#compiling with gcc
CC=g++
BFCC=gcc

#flags of my prof
CFLAGS=-lm -Iinclude -o 


<<<<<<< HEAD
all: api.exe find.exe 
=======
all: api.exe fast-check.exe 
>>>>>>> main

api.exe: src/api.cpp
	$(CC) $(CFLAGS) api.exe src/api.cpp

<<<<<<< HEAD
find.exe: src/find-algorythm.cpp
	$(CC) $(CFLAGS) find.exe src/find-algorythm.cpp

=======
fast-check.exe: src/fast-check.cpp
	$(CC) $(CFLAGS) fast-check.exe src/fast-check.cpp
>>>>>>> main
