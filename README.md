# About project

Program designed for thesis
"checking algorithm Crypto keys for cracking resistance"

# How it works?

```
NOT READY
```

# USAGE

```
NOT READY
```

# P.S.
this program have [windows build](https://github.com/Martinfree/cryptokey-evaluator/tree/Win32App) version
(linux maybe later)

# See also [LICENSE](https://github.com/Martinfree/cryptokey-evaluator/blob/main/LICENSE)


# Plan updates

11.05
1. v0.1 [-f, --find-whoami] ✘ last commit: [83693451f6901a1860c63a5c4b5c50ce0c0eb988](https://github.com/Martinfree/cryptokey-evaluator/commit/83693451f6901a1860c63a5c4b5c50ce0c0eb988)

2. v0.2 [--fast, --fast-check v0.1] ~~JohnTheRipper~~ ✘ last commit: [43f7aa10624653f800189a50fee47181d4ff92c0](https://github.com/Martinfree/cryptokey-evaluator/commit/43f7aa10624653f800189a50fee47181d4ff92c0)


3. v0.3 [add list of algorithms to crack(JohnTheRipper)] до 17.05 ✘ last commit: [e8173896e679f004b14f5fbf1b9da8ef7aa65791](https://github.com/Martinfree/cryptokey-evaluator/commit/e8173896e679f004b14f5fbf1b9da8ef7aa65791)

4. v0.4  WinApp optimization, оптимізація управління та потоків 19.05 ✘ last commit: [c0b4f864981ff5af65b0857189a542be0acfd706](https://github.com/Martinfree/cryptokey-evaluator/commit/c0b4f864981ff5af65b0857189a542be0acfd706) <br>

5. v0.5  --find-secret, ~~--fast-check v0.2 hash and Cyph~~ 20.05 ✘ last commit:[73fce5cf67dff4d307e925592e3006e6f08e3042](https://github.com/Martinfree/cryptokey-evaluator/commit/73fce5cf67dff4d307e925592e3006e6f08e3042)<br>

6. v0.6  --mask-attack ~~--brute-force-attack~~ --dict-attack, Attack can johntheripper 20.05 ✘ last commit: [f4a3ab82b316bed4a3acf78711bba32344299312](https://github.com/Martinfree/cryptokey-evaluator/commit/f4a3ab82b316bed4a3acf78711bba32344299312) <br>

7. v0.7 [ --cracking-resistance, all basic functionality must to be done ] до 21.05 ✘ last commit: [77107f5c6546e45f4dff1ec2eab5a246d26dc6cd](https://github.com/Martinfree/cryptokey-evaluator/commit/77107f5c6546e45f4dff1ec2eab5a246d26dc6cd) <br>

```
Report:
1. brute-force-attack done
2. We need to analyze all the positions:
    - Cypher text - analyze: length, frequency analysis, find format (optional)
    - Secret key (optional) - analyze key(mark for characters), time to crack possibility to find in
    - Complex mark and posibility to attack with extended methods
3. Another optimization
```
8. v0.8 [patch v0.7 problems] 27.05

9. v0.9 [Linux.Makefile, Windows.Makefile, possibility to open more than one hash in file, extended methods, more optimization, --help] - readme done 27.05

10. v1.0 (all interfaces ready) 
