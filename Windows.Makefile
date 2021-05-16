#compiling with gcc
CC=g++
BFCC=gcc

#flags of my prof
CFLAGS=-lm -Iinclude -o 



all: api.exe fast-check.exe 

api.exe: src/api.cpp
	$(CC) $(CFLAGS) api.exe src/api.cpp

fast-check.exe: src/fast-check.cpp
	$(CC) $(CFLAGS) fast-check.exe src/fast-check.cpp
