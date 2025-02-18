# RC_Power

## Description

RC_Reset resets the robot. In many cases this also leads to a reset of a connected robot controller. Depending on the bus system or robot types, in some cases a separate reset may be required for the robot controller.

## Example

<!-- tabs:start -->

#### **Structured Text**

This example shows how to achieve this using Structured Text.

```declaration
PROGRAM Main
VAR
  robot : I_Robot := RoboConnect.Create('manufacturer','model');
  rcReset : RC_Reset;
END_VAR
```

```body
rcReset(
    Robot := robot,
    Execute := true,
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

|         | Type    | Description                                   |
| ------- | ------- | --------------------------------------------- |
| Robot   | I_Robot | Interface to your robot                       |
| Execute | BOOL    | The command is executed with a positive edge. |

## Outputs

|         | Type  | Description                                                                                                                                                                                                                      |
| ------- | ----- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Done    | BOOL  | TRUE if the reset was successfully executed.                                                                                                                                                                                     |
| Busy    | BOOL  | TRUE as soon as the command is started with "Execute" and as long as the command is processed. If "Busy" is FALSE, the function block is ready for a new command. At the same time, one of the outputs "Done" or "Error" is set. |
| Error   | BOOL  | TRUE, if an error occurs.                                                                                                                                                                                                        |
| ErrorID | UDINT | If the error output is set, this parameter supplies the error number.                                                                                                                                                            |
