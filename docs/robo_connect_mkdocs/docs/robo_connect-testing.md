# Unit Testing 

RoboConnect provides a suite of tests for concrete implmentation of RoboConnect. The suite of tests should be run on a fully implemented and live instance of RoboConnect. 

## Usage 

The tests cover each method and property of RoboConnect. To run the tests, they the testing suite needs to be run sequencially in the correct order. The state of the robot will be remembered for each test so it is important to reset any state of the robot between tests if it will break the following test. 

RoboConnects exisiting test library is parameterised to make it easy to extend and set test states of each of the tests. 

## Example 

In the connection tests, the test will force the RoboConnect to disconnect after each test. This means the next sequencial test will be in the correct state to perform it's test. 