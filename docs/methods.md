| Port      | Commands             | Description                                                                                                                                 | Work Item |
| --------- | -------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- | --------- |
| Dashboard | EnableRobot          | enable the robot                                                                                                                            |           |
| Dashboard | DisableRobot         | disable the robot                                                                                                                           |           |
| Dashboard | ClearError           | clear the error of the robot                                                                                                                |           |
| Dashboard | ResetRobot           | the robot stops its current action, and receives enabling again                                                                             |           |
| Dashboard | SpeedFactor          | set the global speed ratio                                                                                                                  |           |
| Dashboard | User                 | select the identified user coordinate system                                                                                                |           |
| Dashboard | Tool                 | select the identified tool coordinate system                                                                                                |           |
| Dashboard | RobotMode            | mode of robot                                                                                                                               |           |
| Dashboard | PayLoad              | Set the load                                                                                                                                |           |
| Dashboard | DO                   | set the status of digital output port                                                                                                       |           |
| Dashboard | DOExecute            | set the status of digital output port (immediate command)                                                                                   |           |
| Dashboard | ToolDO               | Set terminal digital output port status                                                                                                     |           |
| Dashboard | ToolDOExecute        | Set terminal digital output port state (immediate instruction)                                                                              |           |
| Dashboard | AO                   | Set the analog output port status                                                                                                           |           |
| Dashboard | AOExecute            | Set analog output port state (immediate instruction)                                                                                        |           |
| Dashboard | AccJ                 | set the joint acceleration rate. This command is valid only when the motion mode is MovJ, MovJIO, MovJR, JointMovJ                          |           |
| Dashboard | AccL                 | set the Cartesian acceleration rate. This command is valid only when the motion mode is MovL, MovLIO, MovLR, Jump, Arc, Circle              |           |
| Dashboard | SpeedJ               | set the joint velocity rate. This command is valid only when the motion mode is MovJ, MovJIO, MovJR, JointMovJ                              |           |
| Dashboard | SpeedL               | set the Cartesian velocity rate. This command is valid only when the motion mode is MovL, MovLIO, MovLR, Jump, Arc, Circle                  |           |
| Dashboard | CP                   | set the continuous path rate during movement                                                                                                |           |
| Dashboard | PowerOn              | power on the robot                                                                                                                          |           |
| Dashboard | GetAngle             | get the pose in the joint coordinate system                                                                                                 |           |
| Dashboard | GetPose              | get the pose in the Cartesian coordinate system                                                                                             |           |
| Dashboard | EmergencyStop        | emergency stop                                                                                                                              |           |
| Dashboard | GetErrorID           | Get error ID                                                                                                                                |           |
| Dashboard | DI                   | Gets the status of the digital input port                                                                                                   |           |
| Dashboard | ToolDI               | Gets the status of the digital input port                                                                                                   |           |
| Dashboard | AI                   | Get analog input port voltage                                                                                                               |           |
| Dashboard | ToolAI               | Get terminal analog input port voltage                                                                                                      |           |
| Dashboard | DIGroup              | Gets the state of a grop of digital output ports                                                                                            |           |
| Dashboard | DOGroup              | Sets the state of a grop of digital output ports                                                                                            |           |
| Dashboard | LoadSwitch           | Sets the load setting state                                                                                                                 |           |
| Move      | MovJ                 | point to point movement, the target point is Cartesian point                                                                                |           |
| Move      | MovL                 | linear movement, the target point is Cartesian point                                                                                        |           |
| Move      | JointMovJ            | point to point movement, the target point is joint point                                                                                    |           |
| Move      | MoveJog              | Jogging                                                                                                                                     |           |
| Move      | Sync                 | Blocking program execution                                                                                                                  |           |
| Move      | RelMovJTool          | Relative motion is performed along the tool coordinate system, and the end motion is joint motion                                           |           |
| Move      | RelMovLTool          | Relative motion is performed along the tool coordinate system, and the end motion is linear motion                                          |           |
| Move      | RelMovJUser          | Relative motion is performed along the user coordinate system, and the end motion mode is the joint motion                                  |           |
| Move      | RelMovLUser          | Relative motion performed along the user coordinate system, and the end motion mode is a linear motion                                      |           |
| Move      | RelJointMovJ         | Relative motion instruction is conducted along the joint coordinate system of each axis, and the end motion mode is joint motion            |           |
| Feedback  | DigitalInputs        | Current state of the digital inputs.                                                                                                        |           |
| Feedback  | DigitalOutputs       | Digital output                                                                                                                              |           |
| Feedback  | RobotMode            | Robot mode                                                                                                                                  |           |
| Feedback  | TimeStamp            | Time stamp (ms)                                                                                                                             |           |
| Feedback  | SpeedScaling         | Speed scaling of the trajectory limiter                                                                                                     |           |
| Feedback  | QActual              | Actual joint positions                                                                                                                      |           |
| Feedback  | QDActual             | Actual joint velocities                                                                                                                     |           |
| Feedback  | IActual              | Actual joint currents                                                                                                                       |           |
| Feedback  | ToolVectorActual     | Actual Cartesian coordinates of the tool: (x,y,z,rx,ry,rz), where rx, ry and rz is a rotation vector representation of the tool orientation |           |
| Feedback  | TCPSpeedActual       | Actual speed of the tool given in Cartesian coordinates                                                                                     |           |
| Feedback  | TCPForce             | TCP force value (calculated by joint current）                                                                                              |           |
| Feedback  | ToolVectorTarget     | Target Cartesian coordinates of the tool: (x,y,z,rx,ry,rz), where rx, ry and rz is a rotation vector representation of the tool orientation |           |
| Feedback  | TCPSpeedTarget       | Target speed of the tool given in Cartesian coordinates                                                                                     |           |
| Feedback  | MotorTemperatures    | Temperature of each joint in degrees celsius                                                                                                |           |
| Feedback  | User                 | User coordinate                                                                                                                             |           |
| Feedback  | Tool                 | Tool coordinate                                                                                                                             |           |
| Feedback  | RunQueuedCmd         | Queue running flag                                                                                                                          |           |
| Feedback  | PauseCmdFlag         | Queue pause flag                                                                                                                            |           |
| Feedback  | VelocityRatio        | Joint velocity ratio(0~100)                                                                                                                 |           |
| Feedback  | AccelerationRatio    | Joint acceleration ratio(0~100)                                                                                                             |           |
| Feedback  | JerkRatio            | Joint jerk ratio(0~100)                                                                                                                     |           |
| Feedback  | XYZVelocityRatio     | Cartesian position velocity ratio(0~100)                                                                                                    |           |
| Feedback  | RVelocityRatio       | Cartesian pose velocity ratio(0~100)                                                                                                        |           |
| Feedback  | XYZAccelerationRatio | Cartesian position acceleration ratio(0~100)                                                                                                |           |
| Feedback  | RAccelerationRatio   | Cartesian attitude acceleration ratio(0~100)                                                                                                |           |
| Feedback  | XYZJerkRatio         | Cartesian position jerk ratio(0~100)                                                                                                        |           |
| Feedback  | RJerkRatio           | Cartesian pose jerk ratio(0~100)                                                                                                            |           |
| Feedback  | RunningStatus        | Running status                                                                                                                              |           |
| Feedback  | ErrorStatus          | Alarm status                                                                                                                                |           |
| Feedback  | JogStatusCR          | Jogging status                                                                                                                              |           |
| Feedback  | CRRobotType          | Robot type                                                                                                                                  |           |
| Feedback  | User[6]              | User coordinate                                                                                                                             |           |
| Feedback  | Tool[6]              | Tool coordinate                                                                                                                             |           |