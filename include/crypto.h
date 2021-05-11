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
	float TimeToHack;
public:
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
	
	int FormatStr() {
		std::string call_buffer = AppName + AppArgs;
		

		if ( (Pcrypto_finder = popen( call_buffer.c_str(),"r")) == NULL )
		  return EXIT_FAILURE;

		else{

		  std::string result = "";
		  char* buffer = new char [MAXIMUM_BUFFER];
		   // use buffer to read and add to result
		   while(fgets(buffer,MAXIMUM_BUFFER,Pcrypto_finder)){
			 puts(buffer);
			}
			pclose(Pcrypto_finder);

			delete buffer;

		return EXIT_SUCCESS;
	  }
		return EXIT_SUCCESS;
	}

	AppThread(std::string app,std::string args) {
		AppName = app;
		AppArgs = args;
	}

	~AppThread() {
		printf(Result.c_str());
	}
};