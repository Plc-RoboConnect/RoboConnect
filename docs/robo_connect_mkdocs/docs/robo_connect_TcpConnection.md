# T_TcpConnection

T_TcpConnection is used as a class to help manage sending messages of tcp to a tobot controller. T_TcpConnection is composed of classes that use the [TF6310 |TwinCAT 3 TCP/IP](https://infosys.beckhoff.com/english.php?content=../content/1033/tf6310_tc3_tcpip/84141451.html&id=) library.

| Method  | Desciption | 
|---|---|
|  Connect | Connects to a tcp server with ip & port  |  
|  Disconnect | Disconnects from the Tcp server  |  
|  Send | Sends a string message  |   
|  Recieve | Recives from the tcp server   |   
|  IsConnected | Returns true if a connection is established  |  
|  SendingDone | Returns true if TcpSend is done  |  

## T_TcpClientConnect

T_TcpClinetConnect wraps Twincat [FB_ClientServerConnection](https://infosys.beckhoff.com/english.php?content=../content/1033/tf6310_tc3_tcpip/84141451.html&id=) function block as a class. 

| Method  | Desciption | 
|---|---|
|  Connect | Sets FB_ClientServer execute to true  |  
|  Cyclic Logic | Calls FB_ClientServer to maintain the connection  |  
|  Disconnect | Sets FB_ClientServer execute to false  |   
|  Busy | Returns true if FB_ClientServer connection is busy   |   
|  Error | Returns true if FB_ClientServer connection is in error |  
|  IsConnected | Returns true if FB_ClientServer connection is connected  | 
|  Socket | Returns the socket to be used in send and receive methods  | 


## T_TcpReceive

T_TcpReceive wraps twincat [FB_SocketReceive](https://infosys.beckhoff.com/english.php?content=../content/1033/tf6310_tc3_tcpip/84141451.html&id=) in class. 

| Method  | Desciption | 
|---|---| 
|  Cyclic Logic | Calls FB_ClientServer to maintain the connection  |  
|  Receive | Returns the latest message  |   
|  Busy | Returns true if FB_SockReceive connection is busy   |   
|  Error | Returns true if FB_SockReceive connection is in error |   
|  HasSocket | Returns true if the socket has been set |

## T_TcpSend

T_TcpReceive wraps twincat [FB_SocketSend](https://infosys.beckhoff.com/english.php?content=../content/1033/tf6310_tc3_tcpip/84141451.html&id=) in class. 

| Method  | Desciption | 
|---|---| 
|  Cyclic Logic | Calls FB_ClientServer to maintain the connection  |  
|  Send | Sends a string message  |   
|  Busy | Returns true if FB_SockReceive connection is busy   |   
|  Error | Returns true if FB_SockReceive connection is in error |   
|  HasSocket | Returns true if the socket has been set |