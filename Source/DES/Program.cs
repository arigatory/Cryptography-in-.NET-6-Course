﻿/*
MIT License

Copyright (c) 2022

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using Pluralsight.Symmetric;

var key = RandomNumberGenerator.GetBytes(8);
var iv = RandomNumberGenerator.GetBytes(8);
const string original = "Text to encrypt";
const string original2 = "Text to encrypt2";
const string original3 = "Text to encrypt";

var encrypted = DesEncryption.Encrypt(Encoding.UTF8.GetBytes(original), key, iv);
var encrypted2 = DesEncryption.Encrypt(Encoding.UTF8.GetBytes(original2), key, iv);
var encrypted3 = DesEncryption.Encrypt(Encoding.UTF8.GetBytes(original3), key, iv);
var decrypted = DesEncryption.Decrypt(encrypted, key, iv);

var decryptedMessage = Encoding.UTF8.GetString(decrypted);

Console.WriteLine("DES Encryption Demonstration in .NET");
Console.WriteLine("------------------------------------");
Console.WriteLine();
Console.WriteLine("Original Text = " + original);
Console.WriteLine("Encrypted Text = " + Convert.ToBase64String(encrypted));
Console.WriteLine("Encrypted Text = " + Convert.ToBase64String(encrypted2));
Console.WriteLine("Encrypted Text = " + Convert.ToBase64String(encrypted3));
Console.WriteLine("Decrypted Text = " + decryptedMessage);

Console.ReadLine();
