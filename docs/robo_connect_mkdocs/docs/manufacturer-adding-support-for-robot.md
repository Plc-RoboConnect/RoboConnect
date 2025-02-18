# Adding Support for New Robots

RoboConnect is not just a collection of user-facing code, but a backend library that helps manufacturers integrate their robots with TcGraph. To add support for a new robot model, manufacturers will need to follow these steps:

1. Create a new library based on the RoboConnect template library provided. This will serve as the foundation for integrating the new robot model with TcGraph.
2. Create a factory for the new robot model by providing a unique model name for it. This will allow the RoboConnect library to differentiate between different robot models and their specific implementations.
3. Create the base code for the new robot model by extending the RobotBaseClass. This class provides easy-to-use methods and properties that allow the manufacturer to interact with the front-end code of TcGraph.
4. Register which functions the new robot model will support, such as RC_MoveJ. This will inform TcGraph which robot functions can be used with the new robot model. If a function is not registered, TcGraph will display a predefined error code of NOT_SUPPORTED, indicating that the robot does not support that function.

By following these steps, manufacturers can easily integrate their new robot models with TcGraph using the RoboConnect library.

## More than just a library

<img width="" height="" src="./images/backend-overview.png">

RoboConnect is more than just a library for implementing robots and cobots in IEC61131-3 language PLCs. It also provides manufacturers with a range of helper functions and objects that cover some of their usual tasks. These functions and objects are designed to make it easier for manufacturers to integrate their robots with TcGraph and to provide a more seamless user experience. Some of the helper functions and objects provided include:

### Communication objects:

RoboConnect provides a range of communication objects that allow manufacturers to establish and maintain communications between their robots and library. These objects support a variety of communication protocols, such as Modbus TCP, EthernetIP, and Digital IO.

### Streaming data objects:

RoboConnect also provides streaming data objects that allow manufacturers to stream real-time data from their robots to the end user. These objects handle the data transmission and provide a mechanism for users to visualize the data in real-time.

### Asynchronous call objects:

To ensure that the user interface of RoboConnect remains responsive, RoboConnect provides asynchronous call objects that allow manufacturers to execute long-running operations without blocking the user code.

### Feedback objects:

Finally, RoboConnect provides feedback objects that allow manufacturers to provide feedback to users about the status of their robots. These objects can be used to log information, report errors, or display values in real-time.

By providing these helper functions and objects, RoboConnect makes it easier for manufacturers to integrate their robots with TcGraph and to provide a more seamless user experience. This allows users to focus on developing their applications without having to worry about the intricacies of robot integration.
