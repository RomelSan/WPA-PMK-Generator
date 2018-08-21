# WPA PMK Generator
## Description
Generates plainmasterkeys from essid and password for use with hashcat hash-mode 2501  
Also can output to Hashcat and John format to use with mode 12000 - PBKDF2-HMAC-SHA1  
WPA / WPA2 / WPA3 PMK

## Checklist
- [x] Generates WPA PMK
- [x] Can be used in hashcat mode 2501
- [x] Exports to Hashcat mode 12000 and John pbkdf2-hmac-sha1 via wlanwkp2hcx

## Technologies:
Visual Studio 15.8  
Net Framework 4.6.1  
Cygwin v2.893  

## Algorithm
```
PMK = PBKDF2(HMAC−SHA1, PSK, SSID, 4096, 256)
```
The PMK is a SHA1 hashing function with HMAC as the message authentication code.  
The PMK is generated from 4096 iterations of the hashing method and creates a 256-bit PMK  
which is 64 hexadecimal characters and where each hexadecimal character represents 4 bits.  

[RFC2898](http://www.ietf.org/rfc/rfc2898.txt)

## License
MIT License
