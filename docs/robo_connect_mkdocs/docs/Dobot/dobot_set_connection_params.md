The dobot requires an ip address to establish the comunication port for the control of the robot. This is held outside of RoboConnect as it is specific to each manufacture of connection. 

## Requirements
As the comunicaton is based off TCP/IP the libarary uses the [TF6310 | TwinCAT 3 TCP/IP](https://www.beckhoff.com/en-gb/products/automation/twincat/tfxxxx-twincat-3-functions/tf6xxx-connectivity/tf6310.html?). 

## Connection Setup
1) Install the TF6310 software on the target system connected to the robot controller. 

![TF6310 install](images\TF6310_software.png){align=none, loading = Lazy}

This software is found under the software and tools section of product page of [TF6310 | TwinCAT 3 TCP/IP](https://www.beckhoff.com/en-gb/products/automation/twincat/tfxxxx-twincat-3-functions/tf6xxx-connectivity/tf6310.html?). 

2) Connect the target to the controller. 
    [A guide from Beckhoff Infosys](https://infosys.beckhoff.com/content/1033/cx9020_hw/2241767691.html?id=6473746221196773532)

3) Set the IP address of the port on the target connected to the controller. 
    [A Guide from Microsoft](https://support.microsoft.com/en-gb/windows/change-tcp-ip-settings-bd0a07af-15f5-cd6a-363f-ca2b6f391ace)

4) In the variable declaration area in TwinCAT add in a variable to hold the IP address. 

    `ip : T_IPv4Addr := '192.168.5.100';` 

5) Define a variable for the type of robot. 

    `dobotCr3 : T_DobotCR;`

6) Define the command queue and invoker.

    `commandQueue : T_CommandQueue;`

    `commandInvoker : T_CommandInvoker;`


7) Initalise the robot with the command invoker & command queue.

    `commandInvoker.Intialise(commandQueue);`

    `dobotCR3.Initalise(commandInvoker, commandQueue);`

    `dobotCR3.SetConnectionProperties(ip);`


You robot is now initalised and can start working through the internal statemachine shown below. 

![DobotStateMachine](images\RobotStatemachine.png){align=none, Loading=lazy}