this lab demonstrates how value types and reference types behave differently to another variable .

we track what the stack and heap contain



\## case 1: int (value type)



\\\\\\csharp              STACK:           HEAP:     

int a = 5;             a -> 5          (empty)

int b = a;             b -> 10

b = 10;

>>> Value types are copied .Each variable has its own independent box.

==ASII Diagram



**Stack**

**+-----+     +-----+**

**|  a  | --> |  5  |**

**+-----+     +-----+**

**|  b  | --> |  5  |**

**+-----+**

**Heap: (empty)**

\--------------------------------------------------------------------------------------------------



\## CASE 2: String( reference type, immutable)



\\\\\\csharp               STACK                           HEAP:

int s1 = "hello";      S1 -> ref -> "hello"(heap)      "hello"

int s2 = s1;           S2 -> World->"world"(heap)      "world"

s2 = "world";

>>>>strings are reference types, but immutable.Reassigning s2 points it to a new heap object                  



**Stack**

**+-----+           Heap**

**| s1  | --> \[ "hello" ]**

**+-----+**

**| s2  | --> \[ "world" ]**

**+-----+**

**------------------------------------------------------------------------------------------------------------------**



\## CASE 3: CLASS (reference type, mutable)

&#x20;

\\\\\\csharp                                      STACK                                            HEAP:

Person p1 = new Person { Name = "Alice" };    p1 -> ref -> Person { Name = "Bob" } (heap)    Person { Name = "Bob"}

Person p2 = p1;                               p2 -> ref --- ^

p2.Name = "Bob";

>>>>Both the references point to the same heap object.Mutating through one is visible through the other.



Before change==                                                                

Stack                                               

+-----+           Heap                                  

| p1  | --> Person { Name = "Alice" }

+-----+

| p2  | ----┘

+-----+



=== After change

Stack

+-----+           Heap

| p1  | --> Person { Name = "Bob" }

+-----+

| p2  | ----┘

+-----+

\---------------------------------------------------------------------------------------------------------------------------



\## CASE 4: ARRAY of int (reference type,Holds value Types 



\\\\\\CSHARP                     STACK:                                     HEAP:

int\[] arr1 = { 1, 2, 3};    arr1\[0] -> ref ->{ 90 2, 3}(heap)        \[90, 2, 3]

int\[] arr2 = arr1;          arr2\[0] -> ref --^

arr2\[0] = 90;

>>> Arrays are references types.Even  though they hold the value types(int), the array itself lives on the heap. 

assigning arr2 = arr1 copies the reference, so both point to the same block of memory.



Before change

Stack

+------+           Heap

| arr1 | --> \[ 1, 2, 3 ]

+------+ 

| arr2 | ----┘

+------+



After change



Stack

+------+           Heap

| arr1 | --> \[ 90, 2, 3 ]

+------+ 

| arr2 | ----┘

+------+







**SUMMARY**



**.VALUE TYPES -> COPIES -> independent boxes on the stack.**

**.Reference types ->reference copied -> shared heapn object.**

**.Strings -> reference types but immutable, so reassignment creates a new heap object.**

**.ARRAYS  -> reference types, so they share the same heap block even if they contain value types.**





