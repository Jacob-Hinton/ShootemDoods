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
   2. Document Conventions
   3.  Intended Audience and Reading Suggestions
   4.  Product Scope
   5.  References	
2. **Overall Description**	
   1.  Product Perspective	
   2.	Product Functions	
   3.	User Classes and Characteristics	
   4.  Operating Environment	
   5.  Design and Implementation Constraints	
   6.  User Documentation	
   7.  Assumptions and Dependencies	
3. **External Interface Requirements**	
   1.  User Interfaces	
   2.  Hardware Interfaces	
   3.  Software Interfaces	
   4.  Communications Interfaces	
4. **System Features**

5. **Nonfunctional Requirements**

Appendix A: Glossary	

Appendix B: Analysis Models	

Appendix C: To Be Determined List	



# **1.  Introduction**

## 1.1 Purpose
This document shall outline the requirments for the PC game "Shootem Doods". It shall inform of the functional requirements, nonfunctional requirements, scope, constraints, and development process.


## 1.2 Document Conventions
This Document adheres to IEEE standards 830-1998. Within this document, all requirement statements have their own priority. 


## 1.3 Intended Audience and Reading Suggestions
This document is intended to be read by the developers of the software, managers of the project, the client, and any stakeholders of the "Shootem Doods" software system.


## 1.4 Scope
"Shootem Doods" is a Unity based side scrolling shooter for the PC. It shall have multiple levels with branching paths, some of which have "Boss" Enemies at the end. The game is intended to be moderately difficult at minimum, with some paths increasing the difficulty. This increases replay value, which should improve the user's experience. The game should be free to download once built.


"Shootem doods" will be able to detect user inputs from both keyboards, or XInput controllers. The software, once acquired, should not need an internet connection to run. "Shootem Doods" will have conditions for both victory and defeat. Each condition will show the user a series of messages before returning them to the main menu screen.


## 1.5 References


[1] IEEE Software Engineering Standards Committee, “IEEE Std 830-1998, IEEE Recommended Practice for Software Requirements Specifications”, October 20, 1998.



# **2. Overall Description**


###  2.1.  Product Perspective


Shootem Doods is a new, self-contained video game. However, its creation is inspired by the 1985 video game Gradius. Both Shootem Doods and Gradius are side-scrolling shooting games whose win condition is to reach the end screen by to navigate a space ship through a series of levels without receiving a game over screen. In Shootem Doods, however, there will be branching level paths and color themed power ups and enemies.  


Reference Figure one


###  2.2.  Product Functions


*  Basic gameplay support
*  Game transition states
*  Game play obstacles
*  Basic functionality


 Reference Figure one


###  2.3.  User Classes and Characteristics


|UCC-1:	|Player: The Player will play the game by navigating a space ship (see FR-1 & FR-2) through a series levels. The Player does not have to have any technical expertise or any specific level of education in order to play Shootem Doods.   |
|-----|----|


###  2.4.  Operating Environment


|OE-1: |	The product will operate on any machine whose operating system is on or above Windows 7.|
|-----|----|

### 2.5.  Design and Implementation Constraints


|CO-1:	| Platform constraints: Due to restraints in hardware and time for testing, Shootem Doods will be restricted to machines whose operating system is on or above Windows 7. |
|-----|----|

|CO-2:	| Language constraints: All scripts will be written in C# because Unity only supports the C# and JavaScript scripting languages. | 
|-----|----|


###  2.6.  User Documentation


TBD


###  2.7.  Assumptions and Dependencies


It is anticipated that the features provided to us by Unity will allow us to easily implement all of the features in Shootem Doods. Also, it is anticipated that the operating systems Windows 7 and above will support the final published build of Shootem Doods.  


#  **3.  External Interface Requirements**


###  3.1.  User Interfaces
	
Keyboard input device
![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/kybd.png "Keyboard input device")

Sample Xinput controller

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/x360.png "Sample Xinput controller")

Sample title screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/mockupStartScreen.png "Sample title screen")

Sample gameplay screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/screenGrab.png "Sample gameplay screen")

Sample Pause screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/mockUpPauseScreen.png "Sample Pause screen")

Sample continue screen

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/mockupContinueScreen.png "Sample continue screen")


###  3.2.  Hardware Interfaces


The most pertinent hardware interface for Shootem Doods is that the machine running the game is a PC.  It is possible that Shootem Doods will become available on machines running MacOS or a Linux operating system, but, as of now, only PCs are supported. In addition, it is important that the user’s machine has the correct drivers installed for their specific XInput controller (if they decide to use one). To elaborate, different versions of the Windows operating system supports different controllers. For example, Windows 10 now supports XBOX One controllers as well as XBOX 360 controllers. The drivers should be built into the operating system, but it is important that the user checks to make sure that their controller is support on their specific operating system.


Reference Windows Controller API


###  3.3.  Software Interfaces


The software interface that Shootem Doods relies on the most is Unity. Unity is used to both develop and maintain Shootem Doods. Another software interface that Shootem Doods relies on is Windows 7+. This will be the only operating system that the first published build of Shootem Doods will be supported on. It is possible that there will be support for MacOS and Linux operating systems in future builds, but for the first build we only plan on supporting Windows 7 and above. The last software interface that Shootem Doods requires is Paint.net. Paint.net is used to create all of the original artwork used in Shootem Doods as well as any future art for future builds.


###  3.4.  Communications Interfaces


TBD



# **4.  System Features**


##  **4.1 Basic Gameplay Support**


#### 4.1.1 Description and Priority


This feature is the implementation of all things that will allow the Player to play the game. This feature contains things such as moving and shooting, as well as menu navigation and variables that affect the Player during gameplay.


#### 4.1.2  Stimulus Response Sequences



| Actor Actions | System Actions |
|---------------|----------------|
| 1. Player presses W, A, S, D or moves the left analog stick | 2. System detects input from xinput controller or keyboard |
| | 3. System gives a directional velocity to the ship that corresponds to the direction the input indicates |
| | 4. The player ship starts to move in the direction given by the input |
| 5. The player releases the directional key or analog stick | 6. The System removes the directional velocity applied to the player ship |
| | 7. The player ship stops moving |


####  4.1.3  Functional Requirements


| Item | FR-1: Move Player |
|-------| ---------|
|Priority | High |
| Summary | The system should provide one or more ways for the user to move the Player's ship. |
| Rational | If the player is unable to control the player's ship, then the game is unplayable. |
| Requirements |   The Player shall be able to move the ship with keys W, A, S, and D, or the analog stick or directional pad of the XInput device. The User can move the player ship by pressing keys W, A, S, and D on the keyboard, or use of the analog stick or directional pad of the XInput device. |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li></ul> |
| Basic Course of Events | <ul><li>User presses W, A, S, D or moves the left analog stick</li><li>The system moves the player ship in a direction that corresponds with what cardinal direction was indicated</li><li>User releases keyboard key or analog stick</li><li>The system halts the player ship</li></ul> |
| References | FR-18 |



| Item | FR-2: Shoot Weapon  |
|-------| ---------|
|Priority | High |
| Summary | The system should provide one or more ways for the Player to shoot the Player's ship's weapon. |
| Rational | If the player is unable to control the player's ship, then the game is unplayable. |
| Requirements | The Player shall be able to fire the ship's weapon by pressing the spacebar on the keyboard or A button on the XInput device. |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li></ul> |
| Basic Course of Events | <ul><li>The player will press the A button on their xinput controller or press spacebar on the keyboard</li><li>The system will spawn a bullet game object that corresponds to the player ship's current power up state and give it forward speed away from the player ship</li><li>The bullet will continue until it hits an enemy and then it will despawn (unless the player ship has the appropiate power up that allows bullets to pass through enemies) and deal the appropiate amount of damage</li><li>the bullet will also despawn if it encounters an obstacle or travels offscreen</li></ul>  |
| References | FR-17 FR-18 |



| Item | FR-3: Menu Navigation |
|-------| ---------|
|Priority | High |
| Summary |The system should provide one or more ways for the Player to navigate and select options in the menus.  |
| Rational | The player must be able to navigate the menu in order to actually decide when to play, when to stop, and configure the game without resorting to using methods that exist outside the game (manually closing the game through task manager etc.) |
| Requirements | The Player shall be able to navigate menus with keys W, A, S, and D, or the analog stick or directional pad of the XInput device and confirm with either the spacebar or the A button on their Xinput device. |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>The game is either on the start screen, the pause screen, or the game over screen</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li></ul> |
| Basic Course of Events | <ul><li>the player will press W, A, S, D, move the analog stick, or press a directional button on the d-pad</li><li>the game will change the highlighted menu option from where it currently is to where the player indicated with it's direction</li><li>Alternatively, The player presses spacebar or the A button on their xinput device</li><li>The system will then execute the actions specified by the highlighted menu option (ex: start, quit, etc.)</li></ul> |
| References | FR-9 FR-10 FR-11 FR-12 FR-13 FR-14 FR-18 |


| Item | FR-4: Collect Power Ups |
|-------| ---------|
|Priority | High |
| Summary | The system should provide the Player a way to pick up powerups. |
| Rational | Powerups are useless if the Player cannot collect them for later use. This is a core mechanic of the game. |
| Requirements | The player shall be able to pick up a powerup by touching it with the Player's ship. The powerup shall dissappear upon collection. Each powerup shall only be able to be collected once. A player can hold up to three powerups at once. If the player already has 3 powerups held without them being used, the player ship shall not pick up anymore powerups.|
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>There is a power up spawned in the game world.</li></ul> |
| Basic Course of Events | <ul><li>The player passes over a power up item</li><li>The game checks if the player has 3 power ups collected and un-used already</li><li>If the player does not, then the player ship will collect the powerup and despawn it</li><li>When the power up is collected the game will record it in the game's power up gauge which will also be on display for the player to see</li><li>If the player already has 3 powerups, the player ship will simply pass over the power up and nothing will happen</li><ul> |
| References | FR-17 |


| Item | FR-5: Use Power Ups |
|-------| ---------|
|Priority | High |
| Summary | The system should provide a way for the Player to use acquired powerups. |
| Rational | Powerups are useless if not able to be used. |
| Requirements | The Player shall be able to use power ups by pressing key E on the Keyboard or the Right Bumper on the XInput device.  The powerup shall dissappear from the player's inventory upon use. The player shall obtain the effect of the powerup upon usage. Each powerup shall only be able to be used once. A player can use up to three powerups at once.  |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>The player must have one or more powerups collected.</li></ul> |
| Basic Course of Events | <ul><li>The player will press either E on the Keyboard or the Right Bumper on the Xinput device</li><li>The game will check if there are any powerups collected, if there are any the game will then provide the player ship with whatever powerup ability corresponds with the player ship's current powerup combination is</li><li>After giving the player a powerup ability the game will remove all the powerups that have been collected from the player ship</li><li>If there are no powerups collected when the player presses E on the keyboard or Right Bumper on the xinput device, nothing will occur.</li></ul> |
| References | FR-4 FR-18 |


| Item | FR-6: Take Damage |
|-------| ---------|
|Priority | High |
| Summary | The system should provide a way for the player to lose the game. |
| Rational | A side scrolling shooter must have a reason for the player to move and shoot. If the Player cannot take damage, there is no fail state for the game, and the system fails to be a challenge for the player. |
| Requirements | Upon colliding with either an obstacle, an enemy, or upon being hit by an enemy's projectile, the Player's ship shall take 1 stage of damage. If the player has used powerups, the player will lose the powerup ability, and return to a default state. If the player is in the default state, then the player's ship will be destroyed and a life will be lost. |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>The player ship has collided with an obstacle, an enemy, or an enemy's projectile</ul> |
| Basic Course of Events | <ul><li>The player ship collides with an obstacle, an enemy, or an enemy's projectile</li><li>The game will decrement the health of the player</li><li>If the player had a powerup ability they will lose it and be returned to default state and be given 3 seconds of invincibility frames where they cannot take damage again</li><li>If the player ship was already in a default state the ship will be destroyed and the lives requirement (FR-7) will dictate what happens next</li></ul> |
| References | FR-7 FR-15 |


| Item | FR-7: Lose Life |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide Limited tries for the player to complete a level.  |
| Rational | The user should have multiple tries for completing a level before being sent to the beginning and having their score erased. |
| Requirements | Upon taking damage as outlined in FR-6 and if the player was in the default state, then the player will lose a life. The player shall start again at the last checkpoint passed, and the life total shall decrement. If the user has 0 lives upon death they will be prompted with FR-8|
 Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>The player ship has received damage as outlined in FR-6 and was in the default state.</ul> |
| Basic Course of Events | <ul><li>The player ship receives damage in the default state</li><li>The game will destroy the player ship and check the amount of lives left</li><li>If the player has any lives remaining decrement the life count and send the player ship back to the last checkpoint</li><li>If the player is out of lives refer to FR-8</li></ul> |
| References | FR-6 FR-8 |



| Item | FR-8: Use Continue |
|-------| ---------|
|Priority | Low |
| Summary | The system should provide the player with limited tries at completing it.  |
| Rational | The system should not make it too easy for the player to lose the game, but there should still be a punishment for playing poorly so the user will lose their score.  |
| Requirements | Upon losing a life when the life counter is at 0, the Player will be prompted to continue, or accept a game over. Should the player choose to use a continue, the Player will be restarted at the beginning of the level with a score of 0 and the default amount of lives. |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>A level is currently playing and not paused</li><li>The player ship has received damage as outlined in FR-6 and was in the default state.</li><li>The player ship upon death also has 0 lives</li></ul> |
| Basic Course of Events | <ul><li>Upon checking for lives the game will see the player has 0 left</li><li>The game will prompt the player with a Continue? screen and ask if they wish to continue or wish to quit</li><li>if the player chooses the quit option they then go to the Game Over as referenced in FR-10</li><li>If the player chooses the continue option the player will be sent to the beginning of the level and have their score set to 0 </li></ul> |
| References | FR-10 FR-7 |




##  **4.2 Game State Transitions**

#### 4.2.1 Description and Priority


This feature envelops all functions pertaining to changing the state of the system. This includes things such as starting and quitting the game, level progression and transitions, and pausing.


#### 4.2.2  Stimulus Response Sequences



| Actor Actions | System Actions |
|---------------|----------------|
| 1. Player presses W, A, S, D or moves the left analog stick | 2. System detects input from xinput controller or keyboard |
| | 3. System moves the cursor in the proper direction in the menu. |
| | 4. The menu options are highlighted. |
| 5. The player releases the directional key or analog stick | 6. The System stops moving the cursor. |
| | 7. The menu option is highlighted, and ready to be selected. |
| 8.  Player presses the Enter key or the A button on the xinput device | 9.  System detects input from xinput controller or keyboard. |
|  | 10.  System selects the option and makes the proper transition  |


####  4.2.3  Functional Requirements


| Item | FR-9: Start Menu |
|-------| ---------|
|Priority | High |
| Summary | The system should allow the Player to choose when gameplay begins, when to quit, and to view the controls. |
| Rational | The Player should be able to choose when to begin the gameplay to ensure that they are ready to play the game, view controls, and quit the game |
| Requirements | The Player shall navigate the main menu as detailed in FR-3. The game shall display a screen displaying controls if the controls option is selected. The game shall exit if the quit option is selected. The game shall start at the first level if the start option is selected. There shall be no saving or loading of progress. |
| Users | Player |
| Preconditions | <ul><li>The game has been either just been opened or the player has just returned to it from the pause screen or a game over</li></ul> |
| Basic Course of Events | <ul><li>the player will navigate the menu as detailed in FR-3 and select an option</li><li>If the player selected START then the game will transition to the the beginning of level 1</li><li>If the player selected CONTROLS then a control screen will be displayed for the player</li><li>If the player selected QUIT then the game will exit as detailed in FR-19</ul> |
| References | FR-3 FR-10 FR-11 FR-13 |



| Item | FR-10: Game Over |
|-------| ---------|
|Priority | High | 
| Summary | The game should end when the Player loses all lives. |
| Rational | Losing should have consequences. A game over is a common consequence in many games of this style. |
| Requirements | Should a player lose all lives and either choose not to continue, or be out of continues, the game over screeen should be presented. The game should present the game over screen until the player presses spacebar on the keyboard or A on their xinput device. The game should then return the player to the title screen. |
| Users | Player |
| Preconditions | <ul><li>The game is running</li><li>the player decided to not continue after running out of lives and dying</li></ul>  |
| Basic Course of Events | <ul><li>The game will open the Game Over screen upon the player choosing to quit after asked to "continue?"</li><li>This screen will remain until the player presses spacebar on the keyboard or A on their xinput device</li><li>Once the player does this, they are returned to the start screen as referenced in FR-9</li></ul> |
| References | FR-3 FR-11 FR-8 |


| Item | FR-11: Play Level |
|-------| ---------|
|Priority | High |
| Summary | A level should start, and continue until gameplay is ended manually, through a game over, or by completion of the level. |
| Rational | If we don't have requirements for a level to function the player cannot play the game. |
| Requirements | The game shall begin the level upon a game start or a level transition. The level shall run until it is suspended by either a death or a pause. If the level is ended by the player selecting quit at a pause or game over screen, the game shall exit the level and load the title screen. If the Player finishes the level, the game will exit the level and load the next level. |
| Users | Player |
| Preconditions | <ul><li>The game is running</li><li>an event that begins a level (level transition or game start) has occured.</li></ul> |
| Basic Course of Events | <ul><li>level begins and starts running</li><li>this continues unless an event that suspends level play occurs (pause or continue? screen)</li><li>If the player selects quit from any of these menus the level is stopped and the game goes to the start screen</li><li>If the player makes it to the end of the level, then the next level is loaded </li></ul> |
| References | FR-3 FR-8 FR-9 FR-10 FR-12 FR-13 FR-14 |



| Item | FR-12: Transition Levels |
|-------| ---------|
|Priority | High |
| Summary | The system should be able to end the level upon victory, and prepare to start the next level. |
| Rational | The game must be able to continue once one level has been completed. |
| Requirements | When the user completes a level as detailed in FR-11, the System will display the level high score as detailed in FR-20, and waits for the player to press the "Spacebar" key on the keyboard or the "A" key on the Xinput device. Upon the user pressing either of these buttons, the system will cause the screen to fade out to a black screen, the system will load the next level, and the system will begin the new level as is detailed in FR-11.|
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li><li>A level has been completed as detailed in FR-11.</li></ul>  |
| Basic Course of Events | <ul><li>The user completes a level as detailed in FR-11</li><li>The System will display the level high score as detailed in FR-20</li><li>waits for the player to press the "Spacebar" key on the keyboard or the "A" key on the Xinput device</li><li>Upon the user pressing either of these buttons, the system will cause the screen to fade out to a black screen, the system will load the next level, and the system will begin the new level as is detailed in FR-11</li></ul> |
| References | FR-3 FR-11 FR-20 |


| Item | FR-13: Pause Game Menu |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide the player the option to pause the game |
| Rational | Pausing allows the user to stop gameplay for an indefinite period of time so that they do not feel punished by the game if they must leave it due to interruptions.|
| Requirements | When the player is currently playing a level as detailed in FR-11, and the player presses the "M" key on the keyboard or the "Start" button on the Xinput device, the system will display a pause-menu with the options "Resume," "Controls," and "Quit." The system shall allow the user to navigate the pause menu as detailed in FR-3. |
| Users | Player |
| Preconditions |<ul><li>The game is running and is the active window</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li><li>A level is currently playing and not paused</li></ul>  |
| Basic Course of Events | <ul><li>presses the "M" key on the keyboard or the "Start" button on the Xinput device<li><li>Tthe system will display a pause-menu with the options "Resume," "Controls," and "Quit," which can be navigated in the manner outlined in FR-3. </li></ul>   |
| References | FR-3 FR-9 FR-11 FR-14 |


| Item | FR-14: Resume game  |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide the player the option to resume paused gameplay. |
| Rational | If a user cannot resume a paused game, the use of a pause function becomes pointless because the player cannot return to their game after interruption. | Requirements | When the player navigates to the "Resume" option in the pause menu as and selects it as detailed in FR-3, the system will resume suspended gameplay.  |
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li><li>Gameplay is currently paused and on the pause menu</li></ul>  |
| Basic Course of Events | <ul><li>The player navigates to the "Resume" option and selects it as is detailed in FR-3</li><li>The system resumes suspended gameplay.</ul>  |
| References | FR-3 FR-11 FR-13 |


##  **4.3 Gameplay Obstacles**


#### 4.3.1 Description and Priority


This feature consists of things that the Player will face, but do not require any direct input from the player. 


#### 4.3.2  Stimulus Response Sequences


| Actor Actions | System Actions |
|---------------|----------------|
| 1. Player presses the Spacebar on the keyboard or the A button on the xinput device. | 2. System detects input from xinput controller or keyboard |
| | 3. The player's ship generates a projectile |
| | 4. The System detects an enemy being hit by the projectile |
| | 5. The Enemy is destroyed. |

####  4.3.3  Functional Requirements


| Item | FR-15: Collide with Objects |
|-------| ---------|
|Priority | High |
| Summary | The levels shall contain objects that can be collided with, and damage the player's ship upon collision.|
| Rational | Object collisions provide an additional layer of challenge for the player, providing a more enjoyable game experience.|
| Requirements | If the Player's ship collides with a wall, enemy, or other object, then the player's ship shall take damage as outlined in FR-6. The Player's ship shall not continue moving through the wall, enemy, or other object. The Player's ship shall be able to move in directions that allow it to move away from the wall, enemy, or other object. |
|Users| Player|
| Preconditions | <ul><li>The game is running and is the active window</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li><li>A level is currently playing and not paused</li></ul> 
|Basic Course of Events|<ul><li>The user uses the game controls as outlined in FR-1 to navigate the player ship into a solid obstacle.</li><li>The obstacle blocks further movement of the player ship into the obstacle, the ship takes damage as outlined in FR-6</li></ul>  |
| References | FR-6 |



| Item | FR-16: Enemy Behavior |
|-------| ---------|
|Priority | High |
| Summary | The enemies will move in predetermined paths on the screen, in one or more connected lines. These lines can take the form of straight, curved, or sinusoidal lines, depending on the particular definition of the enemy. Additionally, some enemies will shoot projectiles depending on the particular definition of the enemy. |
| Rational | Enemies must move and act in different and varied patterns in order to provide the user with interesting and varied gameplay.|
| Requirements | When an enemy is activated by entering the player's view, the system shall execute the enemy's predetermined path comprised of straight, curved, or sinusoidal lines, and the system may cause the enemy to fire projectiles, all depending on the particular definition of the enemy.|
| References |  |



| Item | FR-17: Destroy Enemies |
|-------| ---------|
|Priority | High |
| Summary | The system should allow the player to destroy enemies|
| Rational | The game would not be fun if the Player's weapon did nothing and would fail to fit the intended genre. |
| Requirements | Upon an enemy being hit by a shot from the player's weapon, the system shall decrement the enemy's hitpoints by the amount outlined in the power up ability table in Appendix B. If the enemy's hitpoints fall to 0 or lower,the system shall destroy the enemy. The system shall display an effect or animation before the enemy disappears depending on the particular enemy's definition. Upon Disappearing, the system shall either leave a red, blue, or yellow power-up corresponding to the enemy's color or leave no power-up, depending on the particular enemy's power-up drop chance. |
| References | FR-2 FR-4 |


##  **4.4 Basic Functionality**


#### 4.4.1 Description and Priority


This feature includes things such as accepting inputs and exiting the application. These are things all programs are generally expected to have.

#### 4.4.2  Functional Requirements


| Item | FR-18: Controller Support |
|-------| ---------|
|Priority | High |
| Summary | The system should provide support for valid Xinput devices supported by Unity and keyboards|
| Rational | If the player is unable to control the game, then the game is unplayable. Control is an essential essential part of the system |
| Requirements | The system shall check if an Xinput compatible controller is connected to the user's device. If no such controller is connected, the system shall accept input from the keyboard. If a compatible controller is connected, the system shall accept user input from the controller. 
| References | FR-1 FR-2 FR-3 FR-5 |

| Item | FR-19: Quit Application |
|-------| ---------|
|Priority | Medium |
| Summary | The system shall provide the player the ability to close the application. |
| Rational | The player should be able to close the game without having to use the operating system task manager|
| Requirements | When The player navigates to the "Quit" option in the main menu and selects it using the controls outlined in FR-3, the system shall produce a dialog box asking the player to confirm "yes" or "no." If the player selects "yes," the application exits. If the player selects "no," the system returns to displaying the previous menu scren|
| Users | Player |
| Preconditions | <ul><li>The game is running and is the active window</li><li>The user has either a keyboard plugged into the computer or a valid xinput device</li><li>The user has navigated to the main menu</li></ul> 
|Basic Course of Events|<ul><li>The user selects the "Exit Game" option on the menu screen</li><li>The system will create a dialogue box asking the user to confirm this action ("Are you sure?" followed by buttons "yes" and "no")</li><li>The system closes the application if the user selects "yes" in the confirm dialogue</li><li>If the user selects "no," return to the menu screen</ul>  |
| References | FR-3 FR-9 FR-13  |

| Item | FR-20: Save High Score|
|-------| ---------|
|Priority | Low |
| Summary | The system shall Save the Player's score if the score is higher than the saved high score. |
| Rational | A high score will motivate players to improve their skills, and therefore invest more time into playing the game. |
| Requirements | Upon a game over, if the player's score is greater than the saved high-score, the system will overwrite the old saved high score and allow the player to enter a 3 character name to assosciate with the high score. |
| References | FR-10 |



# 5.  **Nonfunctional Requirements**


| Item | NF-1 Usability Constraints for Shootem Doods |
|-------| ---------|
| Summary | Shootem Doods should provide the player with features that prevent frustrating of confusing situations.|
| Rational | If interacting with the system is tedious or punishing for a user, the user will not wish to invest time into using the system.|
| Requirements | The system shall provide an option in both the main menu and in-game pause menu to display the controls for gameplay. The controls screen will clearly display the controls using simple controller and keyboard diagrams, depending on whether a user has an Xinput device or keyboard in use respectively for input. When in-game, the system shall provide the ability to pause the game via the in-game pause menu, so that the player does not feel punished for having to put the game down to attend to real-world matters. The system shall support more than one control type to accommodate a player's preferred method of navigating the game. The options in the in-game pause menu and main menu will be clearly marked by their functions: "Start Game," "Controls," and "Quit Game."|
| References | FR-9 FR-15 |


| Item | NF-2 Difficulty Constraints for Shootem Doods |
|-------| ---------|
| Summary | The game is intended to be difficult, but still fair to the player and enjoyable to play. |
| Rational | If the game is too difficult then players may not wish to play it because it is frustrating. If the game is too easy then players may not want to play it because they will not feel that they are being challeneged. If the game feels unfair, then players will not want to play it. |
| Requirements | The system shall provide players with a first level which allows them to experiment and learn the controls of the game and the gameplay features. The system will provide users with challenges that become more difficult as the levels progress. |
| References | FR-16 FR-11 |


| Item | NF-3 Saftey Constraints for Shootem Doods |
|-------| ---------|
| Summary | Shootem Doods should provide the player with an Epliepsy warning. |
| Rational | This will give epileptic users proper warning that the product might be harmful to them, absolving the system designers of personal responsibility for epileptic users harmed by the system.|
| Requirements | An epilepsy warning shall be displayed before the title screen. |
| References | FR-9 |


#  Appendix A: Glossary
|Term | Definition |
|-----|----|
|Player | The End-user. The person playing the game.|
|Player's Ship | The In-game entity the player controls|
| | |

#Appendix B: Analysis Models

Figure one: Component Diagram

![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/Componenet.png "Figure one: Component Diagram")


Figure two: System State Diagram

 ![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/State.png "Figure two: System State Diagram")

Figure Three: power up table


| | one | two | three |
|----|-----|-----|-------|
| Red | machine gun | rocket | lazer |
| Blue | shield | barrel roll | shock wave |
| yellow | speed up | blink | charge attack |

In accordance with the power system, only three can be held at a time and when "cashing in the power ups you receive a power up ability that corresponds with the above table. For example, collecting two blue and one yellow power up would give the player ship a barrel roll ability and a speed up.



