#compiling with g++
CC=g++



#flags
CFLAGS=-lm -Iinclude -o


api.exe: src/api.cpp
	$(CC) $(CFLAGS) api.exe src/api.cpp

find.exe: src/find-algorythm.cpp
	$(CC) $(CFLAGS) find.exe src/find-algorythm.cpp
