# wlanpmk2hcx
From hcxtools 4.2.1  
Link: https://github.com/ZerBea/hcxtools

## Description
Converts plainmasterkey and ESSID for use with hashcat hash-mode 12000 or john PBKDF2-HMAC-SHA1

## Usage
```
wlanpmk2hcx.exe -e <SSID> -p <PMK>
```
## Compile
In Windows you must download Cygwin  
```
make
gcc -c wlanwkp2hcx.c
gcc wlanwkp2hcx.o -o wlanwkp2hcx.exe
```

## License
MIT License
