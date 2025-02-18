# I_RoboConnect

I_RoboConnect is the base interface for all RoboConnect concrete implementations. 

Below are a list of commands and properties a concrete RoboConnect implementation must contain. 

## Methods 

| Method / Function Block       | Description                                                                                                              |
| ----------------------------- | ------------------------------------------------------------------------------------------------------------------------ |
| Enable                        | Enable Robot Axes                                                                                                                     |
| Disable                       | Disable Robot Axes                                                                                                                     |
| Reset                         | Reset Axes / Clear Errors                                                                                                                   |
| Halt                          | Stop movement, no reset required                                                                                                                 |
| Stop                          | Stop movement, reset required                                                                                                                 |
| MoveLinear                    | Move Absolute Linear Cartesian                                                                                                                |
| MoveLinearAdvanced            | Move Absolute Linear Cartesian with Speed, Acceleration, Frame, Tool, Buffer, Type, Transition Type, and Transition Mode                                                                                                                     |
| MoveJoint                     | Move Absolute Joints with Speed and Acceleration                                                                                                             |
| MoveJointsAdvanced            | Move Absolute Joints with Speed & Acceleration                                                                                                             |
| MoveJointsCartesian           | Move Joints in Cartesian Space                                                                                                                    |
| MoveJointsCartesianAdvanced   | Move Joints in Cartesian with Speed, Acceleration, Frame, Tool, Buffer, Type, Transition Type, and Transition Mode                                                                                                                     |
| JogCartesian                  | Jog a Cartesian Axis                                                                   |
| JogJointAxis                  | Jog a joint Axis
| Connect                       | Establishes communication between the PLC and robot controller                         |
| CyclicLogic                   | Handles the statemachine of the robot.                                                 |
| Disconnect                    | Stops comunication between the PLC and robot controller                                |
<!--- | MoveCircularCartesian         | Move Circular Cartesian                                                                                                                |
| MoveCircularCartesianAdvanced | Move Circular Cartesian with more parameters                                                                                                             |--->   




## Sets
| Method / Function Block       | Description                                                                                                              |
| ----------------------------- | ------------------------------------------------------------------------------------------------------------------------ |
| SetUserFrame                  | Sets User Frame Co-ordinates                                                                                                             |
| SetToolFrame                  | Sets Tool Frame Co-ordinates                                                                                                             |
| SetDigitalOutput              | Sets Digital IO                                                                                                                       |
| SetToolDigitalOutput          | Sets Tool Digital IO                                                                                                                       |
| SetAnalogOutput               | Sets Analog IO                                                                                                                       |
| SetJogType                    | Set Jog Type E.g. Joint, Cartesian                                                                                                                |
| SetBufferMode                 | Set Buffer Mode                                                                                                                     | 
| SetTransitionMode             | Set Transition Mode                                                                                                                     |
| SetTransitionParameter        | Set Transition Parameter                                                                                                                |
| SetToolAnalogOutput           | Sets Tool Analog IO                                                                                                                       |
| SetJointAcceleration          | Sets Global Joint Acceleration                                                                                                             |
| SetCartesianAcceleration      | Sets Global Cartesian Acceleration                                                                                                             |
| SetJointSpeed                 | Set Global Joint Speed                                                                                                                    |
| SetCartesianSpeed             | Set Global Cartesian Speed                                                                                                                    |

## Gets
| Method / Function Block       | Description                                                                                                              |
| ----------------------------- | ------------------------------------------------------------------------------------------------------------------------ |
| GetDigitalOutput              | Gets Digital IO                                                                                                                       |
| GetToolDigitalOutput          | Get Tool Digital Output                                                                                                                   |
| GetAnalogOutput               | Get Tool Digital Output                                                                                                                   |
| GetToolAnalogOutput           | Get Tool Analog output                                                                                                                   |
| GetAxisCurrents                | Returns the current drawn in each joint                                               |
| GetAxisTemperature             | Returns the temperature of each joint                                                 |
| GetAxisPositions               | Retuns the current position of each joint                                             |




## Properties 
| Property           | Description                                  |
| ------------------ | ---------------------------------------------|
| Connected          | Status of comunication to robot controller   |
| Enabled            | Actuators Status                             |
| Busy               | Robot Executing Command                      |
| Done               | Robot Finished Command                       |
| Error              | Command generated an error                   |
| Error ID           | Generalised error ID                         |
| Position           | Current TCP positon of end effector          |



