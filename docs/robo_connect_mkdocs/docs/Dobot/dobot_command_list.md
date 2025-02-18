The TCP/IP control is based off of strings, these are held in an enum. When the developer wants to use one of these commands they revernce the enumeration. 

## Control Commands

### PowerOn
Powering on the robot. 

`PowerOn()`

### Enable
Enabling the robot with this command as an extension the command can incude the weight of the load and or the TCP off set. There are 3 different enable commands to call dependent on the optional parameters.

`EnableRobot(Load, centerX, center Y, center Z)`

| Parameter | Type | Description |
|-----------|------|------------|
| Load | REAL | Load weight.The value range should not exceed the load range of corresponding robot models, unit: kg.|
| center X | REAL | Eccentric distance in X-axis direction. Range: -500 – 500, unit: mm.|
| center Y | REAL | Eccentric distance in Y-axis direction. Range: -500 – 500, unit: mm.|
| center Z | REAL | Eccentric distance in Z-axis direction. Range: -500 – 500, unit: mm.|


### Disable
Disabling the robot with this command preventing movement.

`DisableRobot()`

### ClearError
Clears the alarm of the robot. After clearing the alarm, you can judge if the robot is still int he alarm status according to the RobotMode. Some alarms cannot be cleared unless you resolve the alarm cause or restart the controller. 

`ClearError()`

### Reset
Stops the robot and clears the robot's command queue. 

`ResetRobot()`

## RunScript
Run a script that is loaded on the robot controller. 

`RunScript(projectName)`

|Parameter | Type | Description |
|---------| ------|-------------|
|projectName| string | Project Name|

### StopScript

Stop the running project. 

`StopScript()`

### PauseScript

Pause the running project. 

`PauseScript()`

### ContinueScript

Continue running the paused project. 

`ContinueScript()`


### Halt

Pause the motion commands that are currenlty active. 

`Pause()`

### Continue

Corresponding to the Pause command, continue will run the motion command paused by the Pause command.

`Continue()`

### Stop

Stop the robot arm in an emergency. After the emergency stop, the robot arm will power off and alarm. The alarm needs to be cleared before is can be powered on and enabled again. When the software triggers the emergency stop status, delivering the `PowerOn()` command can directly reset and power on the robot arm. 

`EmergencyStop()`

### BrakeControl

Control the brake of the joint specified. The joints automatically brake when the robot is stationary. If you need to move the joint, you can switch on the brake, i.e. hold the joint manually in the disabled status and deliver the command to switch of the brake. 

`BrakeControl(axisID,value)`

## Settings Commands


### SetUserFrame
Sets a custom coordinate system to the base of the robot. The dobot allows for up to 10 user cordinate frames. 

`SetUser(Index,table)`

|Parameter|Type|Description|
|-|-|-|
|Index|INT|Index of the user coordinate system, range: [0,9]. The initial value of
coordinate system 0 is the base coordinate system.|
|Table|STRING|User coordinate system after modification, format: {x, y, z, rx, ry, rz}),
which is recommended to obtain through CalcUser command.|


### SetToolFrame
Sets a custom coordinate system to the end effector of the robot. The dobot allows for up to 10 tool cordinate frames. 

`SetTool(Index,table)`

|Parameter|Type|Description|
|-|-|-|
|Index|INT|Index of the tool coordinate system, range: [0,9]. The initial value of
coordinate system 0 is the base coordinate system.|
|Table|STRING|User coordinate system after modification, format: {x, y, z, rx, ry, rz}),
which is recommended to obtain through CalcUser command.|


### SetJointAcceleration

Set acceleration ratio of joint motion.
The default value is 50 when this command is not called, and the value set by this command will continue
to be maintained after exiting TCP mode.

`AccJ(R)`

|Parameter|Type|Description|
|-|-|-|
|R|INT|Acceleration ratio, range [1,100]|

### SetCartesianAcceleration
Set acceleration ratio of linear and arc motion.
The default value is 50 when this command is not called, and the value set by this command will continue
to be maintained after exiting TCP mode.

`AccL(R)`

|Parameter|Type|Description|
|-|-|-|
|R|INT|Acceleration ratio, range [1,100]|

### SetJointSpeed

Set the speed ratio of the joint motion.
The default value is 50 when this command is not called, and the value set by this command will continue to be maintained after exiting TCP mode. 

`SpeedJ(R)`
|Parameter|Type|Description|
|-|-|-|
|R|INT|Speed ratio, range [1,100]|

### SetCartesianSpeed

Set the speed ratio of the joint motion.
The default value is 50 when this command is not called, and the value set by this command will continue to be maintained after exiting TCP mode. 

`SpeedL(R)`
|Parameter|Type|Description|
|-|-|-|
|R|INT|Speed ratio, range [1,100]|


## Calculating and Obtaining Commands

## IO Commands

### GetDigitalOutput

This can be read through the feedback port.

### SetDigitalOutput
Set the status of the digital output port on the controller

`DO(index,status)`

|Parameter|Type|Description|
|-|-|-|
|index| INT| DO index|
|status|INT|DO status: 1 signal, 0 no signal|

### GetToolDigitalOutput

This can be read through the feedback port.

### SetToolDigitalOutput
Set the status of the digital output port on the end effector of the robot. 

`ToolDI(index,status)`

|Parameter|Type|Description|
|-|-|-|
|index| INT| DO index|
|status|INT|DO status: 1 signal, 0 no signal|


### GetAnalogOutput

This can be read through the feedback port.

### SetAnalogOutput
Set the value of analog output port. 

`AO(index,value)`

|Parameter|Type|Description|
|-|-|-|
|index| INT|AO index|
|value|REAL|AO output|

### GetToolAnalogOutput

This can be read through the feedback port. 

### SetToolAnalogOutput
There is no tool analog output on a dobot. 

## Motion Commands

### MoveLinear

Move tool centre point from the current position to the target Cartesian position through a linear motion. This type of movement will describe a straight line through space from current to target point. 

`MovL(X,Y,Z,Rx,Ry,Rz)`

|Parameter | Type | Description |
|---------| ------|-------------|
| X|REAL| X-axis position of the target point, unit: mm|
| Y|REAL| Y-axis position of the target point, unit: mm|
| Z|REAL| Z-axis position of the target point, unit: mm|
|rX| REAL| Rx-axis position of the target point, unit: °|
|rY| REAL| Ry-axis position of the target point, unit: °|
|rZ| REAL| Rz-axis position of the target point, unit: °|

### MoveLinearAdvanced
This has the same functionailty as MoveL however has the optional parameters of user Cordinate frame, tool cordinate frame, speed ratio & acceleration ratio. 

`MovL(X,Y,Z,Rx,Ry,Rz,User=index,Tool=index,SpeedL=R,AccL=R)`

|Parameter | Type | Description |
|---------| ------|-------------|
| X|REAL| X-axis position of the target point, unit: mm|
| Y|REAL| Y-axis position of the target point, unit: mm|
| Z|REAL| Z-axis position of the target point, unit: mm|
|rX| REAL| Rx-axis position of the target point, unit: °|
|rY| REAL| Ry-axis position of the target point, unit: °|
|rZ| REAL| Rz-axis position of the target point, unit: °|
|user| INT | Index of the user coordinate system, range :[0,9]. The initial value of coordinate system 0 is the base coordinate system. |
|Tool| INT | Index of the Tool coordinate system, range :[0,9]. The initial value of coordinate system 0 is the base coordinate system. |
|speedL|INT| Speed ratio: [1-100]|
|accL | INT| Acceleration ratio: [1-100]|

### MoveJoint
Allows the robot to move between points without specifying a path for the end effector. Instead the robot moves each joint to the target position. 

`JointMovJ(J1,J2,J3,J4,J5,J6)`

|Parameter|Type|Description|
|-|-|-|
J1 |REAL|J1-axis position of the target point, unit: °|
J2 |REAL|J2-axis position of the target point, unit: °|
J3 |REAL|J3-axis position of the target point, unit: °|
J4 |REAL|J4-axis position of the target point, unit: °|
J5 |REAL|J5-axis position of the target point, unit: °|
J6 |REAL|J6-axis position of the target point, unit: °|


### MoveJointAdvanced
This has the same functionailty as JointMoveJ however has the optional parameters of speed ratio & acceleration ratio.

`JointMovJ(J1,J2,J3,J4,J5,J6,SpeedJ=R,AccJ=R)`

|Parameter|Type|Description|
|-|-|-|
J1 |REAL|J1-axis position of the target point, unit: °|
J2 |REAL|J2-axis position of the target point, unit: °|
J3 |REAL|J3-axis position of the target point, unit: °|
J4 |REAL|J4-axis position of the target point, unit: °|
J5 |REAL|J5-axis position of the target point, unit: °|
J6 |REAL|J6-axis position of the target point, unit: °|
|speedJ|INT| Speed ratio: [1-100]|
|accJ | INT| Acceleration ratio: [1-100]|

### MoveJointsCartesian
Move from the current posistion to the target cartesian position with a focus on joint positional change. For joint motion, the trajectory is not linear, and all joints complete the movement simultaneously. 

`MovJ(X,Y,Z,Rx,Ry,Rz)`

|Parameter | Type | Description |
|---------| ------|-------------|
| X|REAL| X-axis position of the target point, unit: mm|
| Y|REAL| Y-axis position of the target point, unit: mm|
| Z|REAL| Z-axis position of the target point, unit: mm|
|rX| REAL| Rx-axis position of the target point, unit: °|
|rY| REAL| Ry-axis position of the target point, unit: °|
|rZ| REAL| Rz-axis position of the target point, unit: °|

### MoveJointsCartesianAdvanced
This has the same functionailty as MoveJointsCartesian however has the optional parameters of speed ratio & acceleration ratio.

`MovJ(X,Y,Z,Rx,Ry,Rz,User=index,Tool=index,SpeedJ=R,AccJ=R)`

|Parameter|Type|Description|
|-|-|-|
| X|REAL| X-axis position of the target point, unit: mm|
| Y|REAL| Y-axis position of the target point, unit: mm|
| Z|REAL| Z-axis position of the target point, unit: mm|
|rX| REAL| Rx-axis position of the target point, unit: °|
|rY| REAL| Ry-axis position of the target point, unit: °|
|rZ| REAL| Rz-axis position of the target point, unit: °|
|speedJ|INT| Speed ratio: [1-100]|
|accJ | INT| Acceleration ratio: [1-100]|

### MoveCircularCartesian
This move will generate a circular tool center point path from current position and two provided points in cartesian space. The robot will then follow this path to the specified count. 

`Circle3({X1,Y1,Z1,Rx1,Ry1,Rz1},{X2,Y2,Z2,Rx2,Ry2,Rz2},count)`

|Parameter|Type|Description
|-|-|-|
|X1|REAL|X-axis position of P1, unit: mm|
|Y1|REAL|Y-axis position of P1, unit: mm|
|Z1|REAL|Z-axis position of P1, unit: mm|
|Rx1|REAL|Rx-axis position of P1, unit: °|
|Ry1|REAL|Ry-axis position of P1, unit: °|
|Rz1|REAL|Rz-axis position of P1, unit: °|
|X2|REAL|X-axis position of P2, unit: mm|
|Y2|REAL|Y-axis position of P2, unit: mm|
|Z2|REAL|Z-axis position of P2, unit: mm|
|Rx2|REAL|Rx-axis position of P2, unit: °|
|Ry2|REAL|Ry-axis position of P2, unit: °|
|Rz2|REAL|Rz-axis position of P2, unit: °|
|Count|INT|Circles of motion, range: 1 – 999.|

### MoveCircularCartesianAdvanced

This has the same functionailty as MoveCircularCartesian however has the optional parameters of speed ratio & acceleration ratio.

`Circle3({X1,Y1,Z1,Rx1,Ry1,Rz1},{X2,Y2,Z2,Rx2,Ry2,Rz2},count,User=index,Tool=index)`

|Parameter|Type|Description
|-|-|-|
|X1|REAL|X-axis position of P1, unit: mm|
|Y1|REAL|Y-axis position of P1, unit: mm|
|Z1|REAL|Z-axis position of P1, unit: mm|
|Rx1|REAL|Rx-axis position of P1, unit: °|
|Ry1|REAL|Ry-axis position of P1, unit: °|
|Rz1|REAL|Rz-axis position of P1, unit: °|
|X2|REAL|X-axis position of P2, unit: mm|
|Y2|REAL|Y-axis position of P2, unit: mm|
|Z2|REAL|Z-axis position of P2, unit: mm|
|Rx2|REAL|Rx-axis position of P2, unit: °|
|Ry2|REAL|Ry-axis position of P2, unit: °|
|Rz2|REAL|Rz-axis position of P2, unit: °|
|Count|INT|Circles of motion, range: 1 – 999.|
|user| INT | Index of the user coordinate system, range :[0,9]. The initial value of coordinate system 0 is the base coordinate system. |
|Tool| INT | Index of the Tool coordinate system, range :[0,9]. The initial value of coordinate system 0 is the base coordinate system. |

### Jog

Jog the robot arm. After the command is delivered, the robot arm will continuously jog along the specified
axis, and it will stop once MoveJog() is delivered. In addition, when the robot arm is jogging, the delivery
of MoveJog(string) with any non-specified string will also stop the motion of the robot arm.
This command is supported by controller V3.5.2 and above.

`MoveJog(axisID)`

|Parameter|Type|Description|
|-|-|-|
|AxisID|STRING|The target axis or axes followed by the direction negative (-) or positive (+). Possible cobinations are J1+, J1-, J2+, J2-, J3+, J3-, J4+, J4-, J5+, J5-, J6+, J6-, X+, X-, Y+, Y-, Z+, Z-, Rx+, Rx-, Ry+, Ry-, Rz+, Rz- Leave empty to stop jog|

### SetJogType
Movejog has an option to set the target coordinate, I have added an advance moveJog 






