# Creating your robot

## Setting up your project

Adding a robot to your project could not be simpler. Just add the RoboConnect Library to your project, plus the RoboConnect manufacturer library which supports your robot type.

## Basic usage of RoboConnect

!> RoboConnect.library will need to be added to your project

In this example we will create, connect, move and disconnect from a MG-400 cobot. You will need to have added the RoboConnect.library, and RoboConnect_Dobot.library to your PLC project.

<!-- tabs:start -->

#### **Structured Text**

This example shows how to achieve this using Structured Text.

```declaration
PROGRAM Main
VAR
  robot : I_Robot := RoboConnect.Create('dobot','mg400');
  rcPower : RC_Power;
  rcMoveJ : RC_MoveJ;
  movePosition : ARRAY [0..5] OF LREAL := [0.601219, 0.202453, 0.146580, 0.000000, 2.902453, -1.202235];
  state : (IDLE, CONNECTING, ENABLE,  MOVE, MOVING, DISABLE, DISCONNECT) := IDLE;

END_VAR
```

```body

CASE state OF

  IDLE :

    robot.Connect();
    state := CONNECTING;

  CONNECTING :
    IF robot.IsConnected THEN
      state := ENABLE;
    END_IF

  ENABLE :

    rcPower(
      Robot := robot,
      Enable := TRUE
    );

    IF rcPower.Status THEN
       state := MOVE;
    END_IF

  MOVE :

    rcMoveJ(
        Robot := robot,
        Position := movePosition; // [0.601219, 0.202453, 0.146580, 0.000000, 2.902453, -1.202235];
        Execute := TRUE;
    );

    state := MOVING;

  MOVING :

    rcMoveJ(
        Robot := robot,
        Execute := FALSE;
    );

    IF rcMoveJ.Done THEN
      state := DISABLE;
    END_IF


  DISABLE:

    rcPower(
      Robot := robot,
      Enable := FALSE
    );

  state := DISCONNECT;

  DISCONNECT:

    robot.Disconnect();

END_CASE;

robot.Update();
```

#### **FBD**

This example shows how to achieve this by using Function Block Diagram.

#### **Ladder**

This example shows how to achieve this by using Ladder Logic.

<!-- tabs:end -->

For more information on how to use RoboConnect, see the [docs](link to documentation) and the [examples](link to examples) directory.
