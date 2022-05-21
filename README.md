# FNG-v5
Fibonacci Number Generator - Given an index the code returns the fibonacci number which is located at the order of index. 

For example:
index = 1 >> fibonacci number is 1
index = 2 >> fibonacci number is 1
index = 3 >> fibonacci number is 2
index = 4 >> fibonacci number is 3
index = 5 >> fibonacci number is 5

This code is generated using TDD.

S for SOLID principle is applied.  >> reason for changing the code may differ under the below circumstances:
Definitin of valid index >> Some believe 0 (zero) is a valid index which represents the fibonacci number is 0 (zero).  
However, some believe zero is not a valid index.

Hence, checking an index is valid or not should be a separate method (Single responsibillity >> "checking if index is a valid index" is a seperate responsibility)

Another reason for change can be "what should be the behaiovur when the index is not valid?" hence returnig the error code (or throwing an exception) should be another method.

So, as of May 21, 2022:  The code consists of three main methods:
1) Checking if index is valid 
2) Return a error code
3) Calculcate fibonnacci number for the given index
4) The main code >> checks if the index is valid, if so, return the fibonacci number, otherwise return the error code.  



