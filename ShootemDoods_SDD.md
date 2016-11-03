___

# <p style="text-align: right;">Software Requirments Specification</p>

</br>

### <p style="text-align: right;">for</p>

</br>

# <p style="text-align: right;">Shootem Doods</p> 

</br>

### <p style="text-align: right;"> Version 1.0 Approved</p>

</br>

<p style="text-align: right;"> Prepared by Jacob Hinton, Brandon Kilpatrick, Chase Bernard, David Xu, Elise Falgout, and Jonah Knickles</p>

</br>

<p style="text-align: right;"> CSC 4330</p>

</br>

<p style="text-align: right;"> 21 October 2016 </p>


# Table of Contents
Table of Contents


1. **Introduction**
   1. Purpose
   2. Audience
   3. Scope
   4. Summary	
2. **Main System Architecture**	
3. **Sub-Systems Architecture**	
4. **Application Views**
   1. Physical View
   2. Physical View
   3. Development View
   4. Database View
   5. Work Assignment View
5. **User Interfaces**
   1. User Interface Description
   2. User Interface Diagrams
6. **Element Catalog**




# **1.  Introduction**

## 1.1 Purpose
This document shall outline the implementation for the PC game "Shootem Doods" as described in the SRS Document. It shall inform all developers of the intended form of the application.

## 1.2 Scope
The Shootem Doods application will contain various levels filled with enemies and objects which pose a hazard to the player, and the player willl need to navigate around them to achieve victory. The player will have various powerups to pick up and use to assist them in beating the levels. This will be gained by destroying enemies or groups of enemies. The player will gain points for destroying enemies and collecting powerups. These points make up the score. The score will be saved at the end of the run, upon either defeat or victory. 
This document will display information about the game to those who are interested


##1.3 References


[1] Gradius [Computer software]. (n.d.). 


[2] IEEE Software Engineering Standards Committee, ÅgIEEE Std 830-1998, IEEE Recommended Practice for Software Requirements SpecificationsÅh, October 20, 1998.


[3] Unity - Manual: Unity Manual. (n.d.). Retrieved October 21, 2016, from https://docs.unity3d.com/Manual/index.html 


#  **2.  Main System Architecture**

Shootem Doods should be Object Oriented in as many ways as we can manage to encapsulate the code as much as possibl. In a game, bugs can arise and be very difficult to deal with if too many things are related to each other. By encapsulating the various entities within the game, the potential for bug fixes harming another portion of the game is reduced, in a addition to making it easier to find bugs. The game runs in Unity and is coded in C#. The game starts with a title screen with a prompt to press the fire key. The game then moves into a menu, which will either call the game to begin, or to view the scores. The game, once started, will generate the level and populate it with enemies and obstacles. The enemies will not begin their behavior until the player, who has loaded into the level at the beginning and makes their way through, has them on screen. Moving obstacles also will not move until the player has them on screen. The enemies, when destroyed by a projectile fired by the player, may drop powerups for the player. The player will be able to collect them. These are all separate objects, and only share small amounts of data with each other to minimize bugs and complexity.


#  **3.  Sub Systems Architecture**
The only Sub System in Shootem Doods is the enemies. It is object oriented as well. It is also partially pipes and filters due to the behavior aspect. There are different types of enemies that are placed inside levels, and each enemy has a behavior. Each is distinct, and a different object inheriting from an enemies superclass. Behaviors are altered to the environment, preventing the enemies from spawning or driving somewhere where they would be destroyed. This is the pipes and filters aspect.


#  **4.  Application views**

##  4.1 Logical View

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/LogView.png "Logical view")


##  4.2 Physical View

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/PhysView.png "Physical View")


##  4.3 Development View

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/DevView.png "Development View")

##  4.4 Database View

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/PhysView.png?raw=true "Database View")


##  4.5 Work-Assignment View
Our responsibilities have been decided as follows:

Database Managmement: Jacob Hinton

Art design: Chase Bernard and Brandon Kilpatrick

Documentation Management and Quality Assurance: Elise Falgout and Jonah Knickles

Core Gameplay Programmers: Jacob Hinton and David Xu 

Level design and Implementation: Chase Bernard and Brandon Kilpatrick

Auxillary Programmers : Elise Falgout and Jonah Knickles

Both Chase and Brandon have done Sprite artwork in the past, so they decided to take the art direction. They also were fairly good at implementing graphical things, so they also took over the level design and implementation, since they felt confident in it. They also assisted in perparation of documents
Jake and David prefer hard coding and have a large amount of experience in doing lower level coding, as well as bug fixing. This was a natural fit for them. Jake also wanted to be the manager of the github repository, since he had managed one before. They also assisted in preparation of documents.
Elise and Jonah had the least programming experience, especially with Unity, though they were both quite versed in UML documentation. They were chiefly in charge of the documentation, though all contributed. They were to make sure documentation was submitted in a timely manner and in good quality. The two would also do black box testing on the product and make sure it was up to standards. They were also expected to help with coding and bugfixes.


#  **5. User Interfaces**
## 5.1 User Interface Description
The UI was designed to be as unintrusive as as possible to allow the player maximal awareness of the playing field. The UI is also designed to display all information that the player needs to play correctly, such as score, number of lives, and power up status. 


## 5.2 User Interface Diagrams

Sample title screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/mockupStartScreen.png "Sample title screen")

Upon startup, the title screen displays the bleak cityscape from the first level, and the first sceen. The screen has options to start, view controls, and quit the game. Choosing Start will bring the player to the gameplay screen. Choosing controls will bring up information about controls. Choosing Quit Game will exit to desktop.

Sample gameplay screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/screenGrab.png "Sample gameplay screen")

The gameplay screen displays powerup status in the top right and will soon display the score and lives. This is unintrusive, allowing maximum space for the player ship to be manuvered and allowing the player to see the scrolling background with parallax effects. Victory or defeat will both save score and return to title, though defeat may bring the player to the continue screen. Pressing pause will bring the player to the Pause screen.

Sample Pause screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/mockUpPauseScreen.png "Sample Pause screen")

The pause screen is accessed from gameplay by pressing the pause key. The screen displays the word pause at the top, with options to resume, view the controls, or quit to title. Resume will go back to the gameplay screen, Controls will bring up an informative thing about the controls, and exit will return to the title screen.

Sample continue screen 

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/mockupContinueScreen.png "Sample continue screen")

The continue Screen supplies the player with a simple choice: Continue or quit. The player can move up and down to select either yes or no. If yes, the player is started at the beginning of the level with a score of zero and the continues counter decrements. If no is selected, the game quits back to the title screen. 

#  **6. Element Catalog**
