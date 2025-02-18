This is a development repository. This Readme is a "working" readme, that will need to be swapped out for a production readme down the line.

RoboConnect shall be a manufacturer and model agnostic library providing generic robot functionality to TwinCAT users. Concrete implementations against the RoboConnect library by manufacturers or end users shall enable users to connect, control and get status from those robots using a common interface – conceptually similar to how users control different drives from the common NC Axis types.

This will benefit system integrators using various robots, and first-time robot users alike, by providing a common interface for them to program against. As adoption of this library improves, further integrations into the Beckhoff ecosystem will enrich and encourage more use. As integrations between RoboConnect and other parts of the Beckhoff eco system are developed, so RoboConnect becomes more attractive. I.e., further development may see the addition of:
- RoboConnect and TcVision closer integrations.
- RoboConnect and Condition Monitoring integrations.
- RoboConnect standard HMI page.
- RoboConnect “recipe” builder function blocks
   - HMI pages for the above.

A list of the methods envisaged for first pass can be found here: [methods](/docs/methods.md)

To get started with the documentation viewer, you will need an installation of [Python](https://www.python.org/downloads/) on your system. Then follow steps the [help.txt](./docs/tc_robot_mkdocs/help.txt) file. If the requirements.txt file is missing a module (i.e. your system asks for more ), please file an issue.