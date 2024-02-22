# Events and Delegates Demo

This project shows how to add events and delegates to a class. 

The project, consisting of a Car class and a console application, is built one step at a time, starting from the basics to the advanced.

### Initial Commit

The Car class consists of a contructor, a Name property and an Accelerate method.
The console application creates an instance of the Car class and calls its Accelerate method.

### Adding the ReachedTopSpeed Event

Assuming the Car class must raise an event once it reaches its top speed of 1,350 km/hr, the code needed to achieve that is shown in this commit.

### Adding the SpeedOfSoundReached Event

Assuming the Car class must raise an event once it reaches the speed of sound of 1,235 km/hr, the code needed to achieve that is shown in this commit.

### Adding the ReportSpeed Event

As the car accelerates, this event reports the car speed in multiples of 100, which can be displayed in the console application. Note that this speed is contained in the CarSpeedEventArgs argument.