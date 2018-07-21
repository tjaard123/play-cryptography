# Cryptography

## Encryption

Encrypting a message, for example a ceasar cipher where we choose a substitute for every letter.  Instead of A we use C, for B we use D.  Therefore the letter plus an index, or key.  This is bidirectional, someone else can decrypt the message with the key.

```
Hello World    -> Ifmmp Xmsme (Key = 1)
Ifmmp Xmsme    -> Hello World (Key = 1)
```

One single key is for symmetric cryptography.  Asymmetric is when there is a public and private key.  Therefore anyone can send you a message that only you can decrypt.

## Digital Signatures

One use of assymmetric encryption is proof that a message was from someone.  Using the public key one can prove that the only person who could have encrypted the message was the one who had the private kry.

## Key Exchange

Diffie helman allows key exchange
Public / private asymmetric cryptogrophy

## Hashing

Hashing is one directional.  A mathematical method that converts a message to jibirish.  It cannot be decrypted.  The same message always converts to the same jibirish.  All messages are always the same length.

```
Hello World    -> Seru30932aljdfk308sl3094803ja0330930mflu20
A whole book   -> afk34d84309aadfdfjaei20984so30948slafj0983
```

Why?
* Hashed password stored in database, if database is stolen, can't retrieve password.  When logging in password is hashed and compared to stored hash to prove it's correct.
* Proof that message hasn't been tampered with, without knowing the content. E.g. a blockchain

