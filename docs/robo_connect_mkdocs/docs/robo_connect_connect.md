Each robot has a feildbus open for plc control, TC-Robot uses that feildbus to control the robot. The following table details the feildbus each robot uses. 

|FeildBus| Robot|
|:----|:---|
|EtherCAT| Staubli|
|TCP/IP | Dobot, Universal Robot E series|

## EtherCAT
The EtherCAT comunication uses the TwinCAT 3 Function [TF5130](https://www.beckhoff.com/en-en/products/automation/twincat/tfxxxx-twincat-3-functions/tf5xxx-motion/tf5130.html?). As this is a configuration change of the PLC enviroment similar to how IO would be configured the method is not implmented, however following these steps will cofigure robot within your project. 

## TCP/IP
The TCP/IP comunication uses the TwinCAT 3 Function [TF6310](https://www.beckhoff.com/en-gb/products/automation/twincat/tfxxxx-twincat-3-functions/tf6xxx-connectivity/tf6310.html?) installed onto the IPC connected to the robot. When calling the connect method a robot using TCP/IP the IP address of the robot should be passed into the method. 

[TODO add in an code snippet of passing in ip address]: #

This will establish the connection required for PLC control of the robot controller. Each robot has multiple ports for various types of commands, the calling of the connect method should establish all of the avaiable ports. For example to turn on a Dobot arm the string "PowerOn()" is required to be sent throught he port 29999. 
For example to power a Dobot robotic arm the string "PowerOn()" should be sent on the dashboard port of 29999.