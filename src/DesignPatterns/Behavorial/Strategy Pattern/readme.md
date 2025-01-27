# STRATEGY PATTERN

is used to pass different algorithms or behaviors to an object

lets consider an application that stores videos. before storing the video, it needs to be compressed using a specific compression algorithm, such as MOV or MP4. then if necessary, apply an overlay to the video, b&w or blur.

## difference between strategy and state pattern

1) state stores a reference to the context object that contains them. whereas, strategy do not
2) states are allowed to replace themselve ( that is to change the state of the context object to something else), while strategies are not.
3) strategies only handle a single, specific task, while states provide the underlying implementation for everything (or almost everything) the context object does.

## when to use it?

when you have a class with large number of conditional statements that switch between variants of the same algorithm.
the algorithm logic can be extracted into seperate classes that implement the same interface.

## pros and cons

1) satisifies ocp 
2) can swap algos used inside an object at runtime.

3) clients have to be aware of the different algorithms and need to select an appropriate one
4) if you only have a few algos that rarely change, then using this pattern may be over engineering.