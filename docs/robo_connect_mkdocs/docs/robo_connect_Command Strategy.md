# Command Strategy 

For TCP issued commands to robot RoboConnect uses the Strategy Patter to hold and execute the commands in order. The commands are string messages send to robot controllers. 

After the method has been called on RoboConnect the command will be set up a T_CommandTask to be executed in the command invoker. 

## T_CommandTask 

A command task is used for executing TCP messages to robot controllers. T_CommandTask implements I_Task so that it can be used in the rest of the system for feedback. 

| Method       | Desciption                                       |
| ------------ | ------------------------------------------------ |
| Initialise   | Initialise the current command with dependancies |
| Cyclic Logic | Runs the state machine for the command task      |
| Abort        | Abort the current command                        |
| Execute      | Execute the command                              |
| Busy         | Command is executing                             |
| Done         | Command is finished executing                    |
| Error        | Error when executing the comand                  |

## I Task 

I_Task is the base interface passed throughout RoboConnect to check if commands have been sent sucessfully. 

| Method  | Desciption                      |
| ------- | ------------------------------- |
| Abort   | Abort the current command       |
| Execute | Execute the command             |
| Busy    | Command is executing            |
| Done    | Command is finished executing   |
| Error   | Error when executing the comand |