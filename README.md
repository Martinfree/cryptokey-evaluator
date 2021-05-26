# About project

This program branch designed for display during the delivery of the thesis
"checking algorithm Crypto keys for cracking resistance"

# How it works?

```


WAIT FOR WORDS...


```

# USAGE

```

WAIT FOR WORDS...
```

# P.S.
```
WAIT FOR WORDS...
```

# Plan updates

11.05
1. v0.1 (first UI, but not works) ✘

2. v0.2 (api v0.3 functionality) 19.05 ✘ last commit: [38fdb88da00e0dc8da2c516c7feee46d0321be7e](https://github.com/Martinfree/cryptokey-evaluator/commit/38fdb88da00e0dc8da2c516c7feee46d0321be7e)
 ```
Report:
 1. "api -fast" not working correct with pass
 2. format returned string api for winapi problematic
 3. maybe some of output must be not in stdout(it's useless)
 4. Need to Machine-cmds (without useless output)
 5. fast-check --analyze-pass have problems with arithmetic
 ```

3. v0.3 (api v0.7 functionality and UI update) 24.05 ✘ last commit: [86797770eb05959ac4d17ee157af0dc3dfa544b0](https://github.com/Martinfree/cryptokey-evaluator/commit/86797770eb05959ac4d17ee157af0dc3dfa544b0)
```
Report:
 1. PS C:\cryptokey-evaluator\Win32App\cryptokey-evaluator> ./api.exe --cracking-resistance --hash-file=d.hash --secret-file=.seckey
terminate called after throwing an instance of 'std::logic_error'
  what():  basic_string::_M_construct null not valid
  when no "--format="
  2. No stdout from attacks
  3. .\api.exe --fast-check .\tets.txt
terminate called after throwing an instance of 'std::logic_error'
  what():  basic_string::_M_construct null not valid
  4. Cypher text length need to be done
  5. --find-pass not working
  6. Exit code needed
```
4. v0.4 ( make threads and calls better, make all work 50% correctly with logic) 25.05 ✘ last commit: [9e40b1edc68dea4989a3a133747f999e1028c218](https://github.com/Martinfree/cryptokey-evaluator/commit/9e40b1edc68dea4989a3a133747f999e1028c218)

5. v0.5 (Need to connect all functions that needed, create new functionality) 26.05 ✘ last commit: [8e50c0966a42b85b74beff9b7590e34759704ed7](https://github.com/Martinfree/cryptokey-evaluator/commit/8e50c0966a42b85b74beff9b7590e34759704ed7)

6. v0.6 (Make config your attack and make UI for hashcat and john attack, make attack working) 26.05 ✘ last commit: []()

7. v0.7 (Open file, Powershell console, add time of work, api v0.8 update) 26.05

8. v0.8 (Design cracking-resistance result, calculate time to hack,make attack working correctly, make TreeView with click show and make possible to download report) 27.05

9. v0.9 (build winapi prog with new structure and connect api v 0.9 ~~several cyph at the same time~~) 27.05

10. v1.0 (all is ready and tested) 27.05
