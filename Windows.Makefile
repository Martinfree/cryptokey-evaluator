#compiling with gcc
CC=g++
BFCC=gcc

#flags of my prof
CFLAGS=-lm -Iinclude -o 


all: api.exe find.exe 

api.exe: src/api.cpp
	$(CC) $(CFLAGS) api.exe src/api.cpp

find.exe: src/find-algorythm.cpp
	$(CC) $(CFLAGS) find.exe src/find-algorythm.cpp

