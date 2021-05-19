/* This file for structure and class manufacture*/

//
// Default cypher class
//
class Cypher {
private:
	std::string Cyph = "<None>";
	std::string OpenKey = "<None>";
	std::string SecretKey = "<None>";
	std::string Algorithm = "<None>";
	std::string AnalyzePassRes[6] = { "","","","","","", };
	double Rate[4] = { 100, 100, 100, 100 }; //Algorithm, Seckey, ..., ...
	float TimeToHack = 0;
public:
	
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
	Cypher(std::string str, std::string secstr, std::string openstr, std::string alg) {
		this->Cyph = str;
		this->SecretKey = secstr;
		this->OpenKey = openstr;
		this->Algorithm = alg;
	}
	
	void InitRes(std::string str, std::string secstr, std::string openstr, std::string alg) {
		this->Cyph = str;
		this->SecretKey = secstr;
		this->OpenKey = openstr;
		this->Algorithm = alg;
	}
	double ChangeRate(int pos, int mark)
	{
		if (pos != -1) this->Rate[pos] = mark;
		return (this->Rate[0] + this->Rate[1] + this->Rate[2] + this->Rate[3])/4;
	}

	void AnalyzePass(std::string str)
	{
		int upper = 0, lower = 0, number = 0, special = 0;
		long double comb = 0.0;
		for (int i = 0; i < str.length(); i++)
		{
			if (str[i] >= 'A' && str[i] <= 'Z')
				upper++;
			else if (str[i] >= 'a' && str[i] <= 'z')
				lower++;
			else if (str[i] >= '0' && str[i] <= '9')
				number++;
			else
				special++;
		}


		if (
			(number != 0) && (upper + lower + special == 0)
			)
			comb = pow(10, str.length());

		else if (
			(lower != 0 && upper + number + special == 0) || (upper != 0 && lower + number + special == 0)
			)
			comb = pow(26, str.length());

		else if (
			(number, lower != 0 && special + upper == 0) || (number, upper != 0 && special + lower == 0)
			)
			comb = pow(36, str.length());

		else if (
			(upper != 0 && lower != 0) && (number + special == 0)
			)
			comb = pow(52, str.length());

		else if (
			number != 0 && upper != 0 && lower != 0 && special == 0
			)
			comb = pow(62, str.length());

		else if (
			special != 0 && lower != 0 && upper != 0 && number == 0
			)
			comb = pow(84, str.length());

		else if (
			number != 0 && lower != 0 && upper != 0 && special != 0
			)
			comb = pow(94, str.length());

		else comb = pow(32, str.length());

		std::stringstream result;
		result << std::string("Password length: ") << std::fixed << std::setprecision(0) << str.length() << std::string("; ");
		this->AnalyzePassRes[0] = result.str();
		result.str("");

		result << std::string("Uppercase: ") << upper << std::string("; ");
		this->AnalyzePassRes[1] = result.str(); 
		result.str("");

		result << std::string("Lowercase: ") << lower << std::string("; ");
		this->AnalyzePassRes[2] = result.str();
		result.str("");

		result << std::string("Numbers: ") << number << std::string("; ");
		this->AnalyzePassRes[3] = result.str();
		result.str("");

		result << std::string("Special: ") << special << std::string("; ");
		this->AnalyzePassRes[4] = result.str();
		result.str("");

		result << std::string("Possible combinations: ") << comb << std::string("; ");
		this->AnalyzePassRes[5] = result.str();
		result << "";

		this->Rate[1] = (upper * 2 + lower + number + special * 3) * 3.5;
	}

	~Cypher() {
		
		printf("Info about Key:\nSecText: %s\nAlgorithm: %s\nOpenKey: %s\nSecKey: %s\n",
			(this->Cyph).c_str(),
			(this->Algorithm).c_str(),
			(this->OpenKey).c_str(),
			(this->SecretKey).c_str());
		
		if (AnalyzePassRes[0] != "") printf("\n%s\n%s\n%s\n%s\n%s\n%s\n",
			(this->AnalyzePassRes[0].c_str()),
			(this->AnalyzePassRes[1].c_str()),
			(this->AnalyzePassRes[2].c_str()),
			(this->AnalyzePassRes[3].c_str()),
			(this->AnalyzePassRes[4].c_str()),
			(this->AnalyzePassRes[5].c_str()));
		
		printf("Mark: %f\n",this->ChangeRate(-1, -1));
			
		
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