# Simple XOR Encryption
This is our submission for Cryptography homework 5 where we had to implement a cryptographic algorithm.
We only found out about this homework at the last day, so we decided to submit simple algithm that we could implement in time (because something is better than nothing)
This project has been tested a bit, but due to deadline, can contain some unforseen mistakes and errors.

Project created together with [Rūdis Rozītis](https://github.com/rudis-rozitis)

## Input
Our project is a simple XOR Encryption implemented in C#/.NET and Windows Forms. You can provide input either as a text or as a file.

## Key
You can input your own key or we made special feature that can generate key with the same length as provided text. Generated key currently contains only capital letters and numbers, but could be upgraded to include other symbols.
If the provided key is shorter than the plaintext, then the key is repeated until all text is encrypted.
