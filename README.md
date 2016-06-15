# **Pig Latin Translator**

##**Description**

An ancient language was recently uncovered which appears to be a close English language derivative.  A group of researchers requires a program to translate English into this ancient text.  Your task is to write a simple program to perform basic English to foreign language translation.

##**Assignment**

Your program should perform translation one line at a time. The program will continue to accept input until it is terminated by entering the word “exit”.
The program output should follow each input line. The translation rules will determine how each word is translated. 

##Translation rules
-	If a word has no letters, don't translate it. 
-	All punctuation should be preserved. (Only , ! ? will be used)
-	If the word begins with a capital letter, then the translated word should too. 
-	Separate each word into two parts. The first part is called the “prefix” and extends from the beginning of the word up to, but not including, the first vowel. (The letter “y” will be considered a vowel.) The Rest of the word is called the “stem.” 
-	The translated text is formed by reversing the order of the prefix and stem and adding the letters “ay” to the end. For example, “sandwich” is composed of “s” + “andwich” + “ay” + “.” and would translate to “andwichsay.” 
-	If the word contains no consonants, let the prefix be empty and the word be the stem. The word ending should be “yay” instead of merely “ay.” For example, “I” would be “Iyay.” 

##Sample session

- Stop => Opstay
- No littering => Onay itteringlay
- No shirts, no shoes, no service => Onay irtsshay, onay eosshay, onay ervicesay
- No persons under 14 admitted => Onay ersonspay underay 14 admitteday
- Hey buddy, get away from my car! => Eyhay uddybah, etgay awayay omfray ymay arcay!
