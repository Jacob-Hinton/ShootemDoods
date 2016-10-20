___

# <p style="text-align: right;">Software Requirments Specification</p>

</br>

### <p style="text-align: right;">for</p>

</br>

# <p style="text-align: right;">Shootem Doods</p> 

</br>

### <p style="text-align: right;"> Version 1.0 Approved</p>

</br>

<p style="text-align: right;"> Prepared by Jacob Hinton, Brandon Kilpatrick, Chase Bernard, David Xu, Elise Falgout and Jonah Knickles</p>

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

5. **Other Nonfunctional Requirements**
   1.  Performance Requirements	
   2.  Safety Requirements	
   3.  Security Requirements	
   4.  Software Quality Attributes	
   5.  Business Rules
6. **Other Requirements	**

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



# **4.  System Features**

| Item | FR-1: Controller Support |
|-------| ---------|
|Priority | High |
| Summary | The system should provide one or more ways for the Player to make inputs |
| Rational | If the player is unable to control the game, then the game is unplayable. Control is a highly essential part of the system |
| Requirements | The system should check if an XInput compatible controller is connected to the user's device. If no such controller is connected, the system will accept input from the keyboard.If a compatible controller is connected, it will accept user input from the controller. These inputs will be used to move the Player's ship, shoot the player's weapon, navigate menus|
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-2, FR-3, FR-4 |


| Item | FR-2: Move Player |
|-------| ---------|
|Priority | High |
| Summary | The system should provide one or more ways for the user to move the Player's ship. |
| Rational | If the player is unable to control the player's ship, then the game is unplayable. |
| Requirements |   The Player shall be able to move the ship with keys W, A, S, and D, or the analog stick or directional pad of the XInput device. The User can move the player ship py pressing keys W, A, S, and D on the keyboard, or use of the analog stick or directional pad of the XInput device. |
| Users | Player |
| Preconditions |* The game is running and is the active window 
* The user has either a keyboard plugged into the computer or a valid xinput device |
| Basic Course of Events | * User presses W, A, S, D or moves the left analog stick
* The system moves the player ship in a direction that corresponds with what cardinal direction was indicated
* User releases keyboard key or analog stick
* The system halts the player ship |
| References | FR-1 |


| Actor Actions | System Actions |
|---------------|----------------|
| 1. Player presses W, A, S, D or moves the left analog stick | 2. System detects input from xinput controller or keyboard |
| | 3. System gives a directional velocity to the ship that corresponds to the direction the input indicates |
| | 4. The player ship starts to move in the direction given by the input |
| 5. The player releases the directional key or analog stick | 6. The System removes the directional velocity applied to the player ship |
| | 6. The player ship stops moving |


| Item | FR-3: Shoot Weapon  |
|-------| ---------|
|Priority | High |
| Summary | The system should provide one or more ways for the Player to shoot the Player's ship's weapon. |
| Rational | If the player is unable to control the player's ship, then the game is unplayable. |
| Requirements | The Player shall be able to fire the ship's weapon by pressing key **TODO** on the keyboard or button **TODO** on the XInput device. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-1 |



| Item | FR-4: Menu Navigation |
|-------| ---------|
|Priority | High |
| Summary |The system should provide one or more ways for the Player to navigate the menus.  |
| Rational | The player must be able |
| Requirements | The Player shall be able to navigate menus with keys W, A, S, and D, or the analog stick or directional pad of the XInput device. The User can move the player ship py pressing keys W, A, S, and D on the keyboard, or use of the analog stick or directional pad of the XInput device. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-1 |


| Item | FR-5: AI Behavior |
|-------| ---------|
|Priority | High |
| Summary | |
| Rational | |
| Requirements |  |
| References |  |


| Item | FR-6: Start Game |
|-------| ---------|
|Priority | High |
| Summary | The system should allow the Player to choose when gameplay begins. |
| Rational | The Player should be able to choose when to begin the gameplay to ensure tha they are ready to play the game. |
| Requirements | The Player shall navigate the main menu to the "Start" Option, and proceed to select the option by pressing the **TODO** key on the keyboard or the **TODO** button on the XInput device. The game should start at the first level. There shall be no saving or loading of progress. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |



| Item | FR-7: Game Over |
|-------| ---------|
|Priority | High | 
| Summary | The game should end when the Player loses all lives. |
| Rational | Losing should have consequences. A game over is a common consequence in many games of this style. |
| Requirements | Should a player lose all lives and either choose not to continue, or be out of continues, the game over screeen should be presented. The game should present the game over screen until the player inputs any non-directional input. The game should then return the player to the title screen. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |


| Item | FR-8: Quit Game |
|-------| ---------|
|Priority | Low |
| Summary | The player should be able to manually end gameplay. |
| Rational | The player may wish to end gameplay, so it should be possible for them to do so. |
| Requirements | The player shall press the pause button, bringing up the pause menu. The Player shall then select "Quit" and press **TODO** to confirm. The game shall then return to the main menu.  |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |




| Item | FR-9: Play Level |
|-------| ---------|
|Priority | High |
| Summary | A level should start, and continue until gameplay is ended manually, through a game over, or by completion of the level. |
| Rational | |
| Requirements |  |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |



| Item | FR-10: Transition Levels |
|-------| ---------|
|Priority | High |
| Summary | The system should be able to end the level upon victory, and prepare to start the next level. |
| Rational | The game must be able to continue once one level has been completed. |
| Requirements |  |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |



| Item | FR-11: Destroy Enemies |
|-------| ---------|
|Priority | High |
| Summary | The system should allow the player to destroy enemies|
| Rational | The game would not be fun if the Player's weapon did nothing and would fail to fit the intended genre. |
| Requirements | Upon an enemy being hit by a shot from the player's weapon, the enemy should be destroyed. The enemy should display an animation before disappearing. Upon Disappearing, enemies shall leave behind a powerup under conditions to be discussed. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |



| Item | FR-12: Collect Power Ups |
|-------| ---------|
|Priority | High |
| Summary | The system should provide the Player a way to pick up powerups. |
| Rational | Powerups are useless if the Player cannot collect them for later use. This is a core mechanic of the game. |
| Requirements | The player shall be able to pick up a powerup by touching it with the Player's ship. The powerup shall dissappear upon collection. Each powerup shall only be able to be collected once. A player can hold up to three powerups at once. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References |  |


| Item | FR-13: Use Power Ups |
|-------| ---------|
|Priority | High |
| Summary | The system should provide a way for the Player to use acquired powerups. |
| Rational | Powerups are useless if not able to be used. |
| Requirements | The Player shall be able to use power ups by pressing key **TODO** on the Keyboard or button **TODO** on the XInput device.  The powerup shall dissappear from the player's inventory upon use. The player shall obtain the effect of the powerup upon usage. Each powerup shall only be able to be used once. A player can use up to three powerups at once.  |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-1 |


| Item | FR-14: Take Damage |
|-------| ---------|
|Priority | High |
| Summary | The system should provide a way for the player to lose the game. |
| Rational | A side scrolling shooter must have a reason for the player to move and shoot. If the Player cannot take damage, there is no reason to continue through the game, and the system fails to be a side scrolling shooter. |
| Requirements | Upon colliding with an object as outlined in FR-17, or upon being hit by an enemy's projectile, the Player's ship shall take 1 stage of damage. If the player has used powerups, the player will lose the effects, and return to the default state. If the player is in the default state, then the player's ship will be destroyed and a life will be lost. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-15, FR-17 |


| Item | FR-15: Lose Life |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide Limited tries for the player to complete a level.  |
| Rational | The player should have multiple tries for completing a level before being restarted to the beginning and having their score erased. |
| Requirements | Upon taking damage as outlined in FR-14 and if the player was in the default state, then the player will lose a life. The player shall start again at the last checkpoint passed, and the life total shall decrement |
| References | FR-14, FR-17 |



| Item | FR-16: Use Continue |
|-------| ---------|
|Priority | Low |
| Summary | The system should provide the player with limited tries at completing it.  |
| Rational | The system should not make it too easy for the player to lose the game.  |
| Requirements | Upon losing a life when the life counter is at 0, the game will check to see if the Player has any continues. If the player has continues, the Player will be prompted to choose to use one, or accept a game over. Should the player choose to use a continue, the Player will be restarted at the beginning of the level with a score of 0 and the default amount of lives. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-4 |



| Item | FR-17: Collide with Objects |
|-------| ---------|
|Priority | High |
| Summary | The levels shall contain objects that can be collided with, and the system needs to be able to deal with it. |
| Rational | The Player is not meant to go through walls objects . The Player is meant to avoid walls and objects.  |
| Requirements | If the Player's ship collides with a wall, enemy, or other object, then the player's ship shall take damage as outlined in FR-14. The Player's ship shall not continue moving through the wall, enemy, or other object. The Player's ship shall be able to move in directions that allow it to move away from the wall, enemy, or other object. |
| References | FR-14 |



| Item | FR-18: Quit Application |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide the player the ability to close the application. |
| Rational | Closing the application is basic functionality. |
| Requirements | The player shall navigate to the "Quit" option in the main menu and select it. The system shall produce a dialog box asking the player to confirm. Should the player confirm, the system shall close the window and end. |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-4 |


| Item | FR-19: Pause game  |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide the player the option to  |
| Rational | Pausing is a function considered standard in the side scrolling shooter genre. |
| Requirements | The player shall press the **TODO** key on the keyboard or the **TODO** button on the XInput device. The system shall then suspend gameplay and produce a menu for the player containing the options "Resume" and "Quit". |
| Users | Player |
| Preconditions | |
| Basic Course of Events |  |
| References | FR-1 |



| Item | FR-20: Resume game  |
|-------| ---------|
|Priority | Medium |
| Summary | The system should provide the player the option to resume paused gameplay. |
| Rational | The pause function would cause the application to fail without this functionality. |
| Requirements | The player shall select the resume key and press the **TODO** key on the keyboard or the **TODO** button on the XInput device. The system will resume suspended gameplay. |
| Users | Player |
| Preconditions | FR-19 |
| Basic Course of Events |  |
| References | FR-1, FR-19 |


# 5.  **Nonfunctional Requirements**


| Item | NF-1 Usability Constraints for Shootem Doods |
|-------| ---------|
| Summary | Shootem Doods should provide the player with all they need to know to play the game and various things to make playing the game more enjoyable. |
| Rational | IF the playerknows the controls, they will enjoy playing the game more. If the player can pause the game, they may appreciate the ability to suspend gameplay. Exiting levels and quitting the application provide a way to stop playing for the player. |
| Requirements | The controls shall be presented to the player before beginning gameplay and during the first level. The controls and controller supports must be implemented correctly to ensure proper gameplay. The pause function must be implemented correctly to ensure proper gameplay. The resume function must be implemented correctly to ensure proper gameplay. The Quit Application function must be implemented correctly to ensure proper gameplay. |
| References | FR-1 FR-2 FR-3 FR-4 FR-6 FR-7 FR-8 FR-9 FR-10 FR-11 FR-12 FR-13 FR-16 FR-17 FR-18 FR-19 FR-20|


| Item | NF-2 Difficulty Constraints for Shootem Doods |
|-------| ---------|
| Summary | The game is intended to be difficult, but still fair to the player and enjoyable to play. |
| Rational | If the game is too difficult then players may not wish to play it. If the game is too easy then players may not want to play it. If the game feels unfair, then players will not want to play it. |
| Requirements | The default amount of lives given to the player must be equal to or greater than three and less than or equal to 5. The levels should last from NUM minutes to NUM minutes. The player should be given 2 continues. The enemies shall not move until the player has them on screen. The levels shall not consist of trial and error. The first level should provide an environment for the player to learn the controls and techniques of the game.  |
| References | FR-5 FR-9 FR-12 FR-13 FR-14 FR-15 FR-16 FR-17 |





