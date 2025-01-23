## Pros and cons of state pattern 

there can be a possibility of overkill 

so in a stopwatch you can have only 2 states - start or stop 
using the state pattern here can cause an overkill, that is to create classes for starting and stopping

it is pretty straight forward, we are not going to add any more states in the long run 

1) improves readibility and simplicity of the context class by eliminating conditions
2) satisfies OCP
3) satisfies SRP
4) this pattern can be an overkill, if there are a few states, and that if the state logic changes rarely

## when to use it?

when you have a class that behaves based on its states, and you have large number of conditions - if else statements and all

then you have a good indication that you should have a layer of abstraction.

