# RC_Power

## Description

RC_Power activates software enable for a robot. At "Status" output operational readiness of the robot is indicated. A velocity override influences the velocity of all travel commands by a specified percentage. Depending on the drive type, “Status” also signals operational readiness of the robot.

## Example

<!-- tabs:start -->

#### **Structured Text**

This example shows how to achieve this using Structured Text.

```declaration
PROGRAM Main
VAR
  robot : I_Robot := RoboConnect.Create('manufacturer','model');
  rcPower : RC_Power;
END_VAR
```

```body
rcPower(
    Robot := robot,
    Enable := true,
    Override := 100.0,
    Status => bStatus,
    Busy => bBusy,
    Active => bActive,
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

|          | Type    | Description                                                            |
| -------- | ------- | ---------------------------------------------------------------------- |
| Robot    | I_Robot | Interface to your robot                                                |
| Enable   | BOOL    | General software enable for the robot.                                 |
| Override | LREAL   | Velocity override in % for all motion commands. (0 ≤ Override ≤ 100.0) |

## Outputs

|         | Type  | Description                                                                                                                                                                                                                      |
| ------- | ----- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Status  | BOOL  | TRUE when the robot is ready for operation.                                                                                                                                                                                      |
| Busy    | BOOL  | TRUE as soon as the command is started with "Execute" and as long as the command is processed. If "Busy" is FALSE, the function block is ready for a new command. At the same time, one of the outputs "Done" or "Error" is set. |
| Active  | BOOL  | Indicates that the command is executed.                                                                                                                                                                                          |
| Error   | BOOL  | TRUE, if an error occurs.                                                                                                                                                                                                        |
| ErrorID | UDINT | If the error output is set, this parameter supplies the error number.                                                                                                                                                            |
