/* This file for structure and class manufacture*/

//
// Default cypher class
//
class Cypher {
private:
	std::string Cyph;
	std::string OpenKey;
	std::string SecretKey;
	std::string Algorithm;
	FILE* CyphFile;
	float TimeToHack;
public:
	//write hash to file for JohnTheRipper, Hascat and other progs
	void FileWrite(std::string cyph) {
		
		this->CyphFile = fopen(cyph.c_str(), "wa+");
		fprintf(CyphFile, cyph.c_str());
		fclose(CyphFile);
	}
	
	Cypher(std::string str) {
		this->Cyph = str;
		
	}
	
	Cypher(std::string str, std::string secstr) {
		this->Cyph = str;
		
	}
	
	Cypher(std::string str, std::string secstr, std::string openstr) {
		this->Cyph = str;
		
	}

};


//
// For create process
//EXAMPLE: AppThread FindExe(std::string("find.exe").c_str(), std::string("-k").c_str());
class AppThread {
private:
	std::string AppName;
	std::string AppArgs;
	std::string Result;
public:

	int Exec() {

		std::string call_buffer = this->AppName + this->AppArgs;
		char* buffer = new char[MAXIMUM_BUFFER];
		
		if (
			(Pcrypto_finder = popen(call_buffer.c_str(), "r")) == NULL
			)	
			return EXIT_FAILURE;
	else {
		   // use buffer to read result
			
		   while(
			   fgets(buffer,MAXIMUM_BUFFER,Pcrypto_finder)
			   )
		   {
			  puts(buffer);
		   }
		   
		   pclose(Pcrypto_finder);
		   
			this->Result = std::string(buffer);

			delete buffer;
			

		return EXIT_SUCCESS;
	  }
		return EXIT_SUCCESS;
	}

	AppThread(std::string app,std::string args) {
		this->AppName = app;
		this->AppArgs = args;
	}

	~AppThread() {
		printf("\n%s\n",(this->Result).c_str());
	}
};