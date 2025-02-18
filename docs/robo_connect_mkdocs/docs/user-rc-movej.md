# RC_MoveJ

## Description

The RC_MoveJ function is a command used to move a robotic arm or cobot from its current position to a specified position along a predefined path using joint motion. It takes in two inputs: the robot object and an array of LREAL values representing the positions of each joint of the robot arm.

The RC_MoveJ function specifies the positions and orientations of each joint of a robotic arm, allowing it to move from one point to another in a smooth and controlled manner. The LREAL array input represents the desired positions of each joint, and the robot object input represents the specific robot or cobot that will perform the motion.

## Example

<!-- tabs:start -->

#### **Structured Text**

This example shows how to achieve this using Structured Text.

```declaration
PROGRAM Main
VAR
  robot : I_Robot := RoboConnect.Create('manufacturer','model');
  movePosition : ARRAY [0..5] OF LREAL := [0.601219, 0.202453, 0.146580, 0.000000, 2.902453, -1.202235];
  rcMoveJ : RC_MoveJ;
END_VAR
```

```body
rcMoveJ(
    Robot := robot,
    Execute := true,
    Positions := movePosition;
    Done => bDone,
    Busy => bBusy,
    Error => bError,
    ErrorID => nErrorID
);

robot.Update();
```

#### **FBD**

This example shows how to achieve this by using Function Block Diagram.

#### **Ladder**

This example shows how to achieve this by using Ladder Logic.

<!-- tabs:end -->

## Inputs

|          | Type               | Description                                                                                                                       |
| -------- | ------------------ | --------------------------------------------------------------------------------------------------------------------------------- |
| Robot    | I_Robot            | Interface to your robot                                                                                                           |
| Execute  | BOOL               | The command is executed with a positive edge.                                                                                     |
| Position | Array [*] OF LREAL | Each position listed as an array of LREAL. Supplying less than the total number of joints will use the value of 0 for that joint. |

## Outputs

|         | Type  | Description                                                                                                                                                                                                                      |
| ------- | ----- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Done    | BOOL  | TRUE if the move was successfully completed.                                                                                                                                                                                     |
| Busy    | BOOL  | TRUE as soon as the command is started with "Execute" and as long as the command is processed. If "Busy" is FALSE, the function block is ready for a new command. At the same time, one of the outputs "Done" or "Error" is set. |
| Error   | BOOL  | TRUE, if an error occurs.                                                                                                                                                                                                        |
| ErrorID | UDINT | If the error output is set, this parameter supplies the error number.                                                                                                                                                            |
