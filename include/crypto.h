/* This file for structure and class manufacture*/

//
// Default cypher class
//
class Cypher {
private:
	std::string Cyph = "<None>";
	std::string OpenKey = "<None>";
	std::string SecretKey = "<None>";
	std::string SecKeyCombination = "<None>";
	std::string Algorithm = "<None>";
	double Rate[4] = { 100, 100, 100, 100 }; //Algorithm, Seckey, ..., ...
	FILE* CyphFile;
	float TimeToHack = 0;
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
		this->SecretKey = secstr;
	}
	
	Cypher(std::string str, std::string secstr, std::string openstr) {
		this->Cyph = str;
		this->SecretKey = secstr;
		this->OpenKey = openstr;
	}
	Cypher(std::string str, std::string secstr, std::string openstr, std::string alg ,std::string secstr_comb) {
		this->Cyph = str;
		this->SecretKey = secstr;
		this->OpenKey = openstr;
		this->Algorithm = alg;
		this->SecKeyCombination = secstr_comb;
	}
	void Init(std::string str, std::string secstr, std::string openstr, std::string alg, std::string secstr_comb) {
		this->Cyph = str;
		this->SecretKey = secstr;
		this->OpenKey = openstr;
		this->Algorithm = alg;
		this->SecKeyCombination = secstr_comb;
	}
	double ChangeRate(int pos, int mark)
	{
		if (pos != -1) this->Rate[pos] = mark;
		return (this->Rate[0] + this->Rate[1] + this->Rate[2] + this->Rate[3])/4;
	}
	~Cypher() {
		printf("Info about Key:\nSecText: %s\nAlgorithm: %s\nOpenKey: %s\nSecKey: %s\nSecKeyCombination: %s\nMark: %f\n", 
			(this->Cyph).c_str(), 
			(this->Algorithm).c_str(),
			(this->OpenKey).c_str(),
			(this->SecretKey).c_str(),
			(this->SecKeyCombination).c_str(),
			(this->ChangeRate(-1,-1))
		);
	}
};


//
// For create process
//EXAMPLE: AppThread FindExe(std::string("find.exe").c_str(), std::string("-k").c_str());
class AppThread {
private:
	std::string AppName;
	std::string AppArgs;
	
public:
	std::string Result;
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