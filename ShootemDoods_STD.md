___

# <p style="text-align: left;">Software Testing Document</p>

</br>

### <p style="text-align: left;">for</p>

</br>

# <p style="text-align: left;">Shootem Doods</p>

</br>

### <p style="text-align: left;"> Version 1.0 Approved</p>

</br>

<p style="text-align: left;"> Prepared by Steven Chase Bernard, Elise Falgout,
Jacob Hinton, Brandon Kilpatrick, Jonah Knickles and David Xu</p>

</br>

<p style="text-align: left;"> CSC 4330</p>

</br>

<p style="text-align: left;"> 21 November 2016 </p>
# Table of Contents
Table of Contents

1. **Introduction**
   1. Purpose
   2. Document Conventions  
2. **Functional Requirements Test Cases**
   1. Move Player
   2. Shoot Weapon
   3. Menu Navigation
   4. Collect Power-ups
   5. Use Power-ups
   6. Take Damage
   7. Lose Life
   8. Use Continue
   9. Start Menu
   10. Game Over  
   TC-10.1: Correct Keyboard Input  
   TC-10.2: Correct XInput Input  
   TC-10.3: Incorrect Input
   11. Play Level  
   TC-11
   12. Transition Levels  
   TC-12.1: Correct Input  
   TC-12.2: Incorrect Input
   13. Pause Game Menu  
   TC-13.1: Keyboard Input  
   TC-13.2: XInput Input
   14. Resume Game  
   TC-14: Resume Suspended Gameplay
   15. Collide with Objects  
   TC-15: Take Damage
   16. Enemy Behavior  
   TC-16: Check Enemy Movement
   17. Destroy Enemies  
   TC-17: Check Enemy Death
   18. Controller Support  
   TC-18.1: Check XInput Input  
   TC-18.2: Check Keyboard Input
   19. Quit Application  
   TC-19.1: Check 'Yes' Option  
   TC-19.2: Check 'No' Option
   20. Save High Score  
   TC-20: Check Save High Score  

# **Introduction**
## 1. Purpose
## 2. Document Conventions

# **Functional Requirements Test Cases**
## 1. Move Player
## 2. Shoot Weapon
## 3. Menu Navigation
## 4. Collect Power-ups
## 5. Use Power-ups
## 6. Take Damage
## 7. Lose Life
## 8. Use Continue
## 9. Start Menu    
## 10. Game Over
### TC-10.1: Correct Keyboard Input
___
**System:** *Shootem Doods*  
**Subsystem:** Game Over  
**Created by:**    
**Executed by:**    
**Short Description:** Tests that pressing the spacebar on the keyboard at the
Game Over screen returns the Player to the title screen.
___

**Pre-conditions**  
* The game is running  
* The Player decided to not continue or is out of continues when they ran out of
lives.


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press the spacebar| The game returns you to the title screen|  |  ||
___
**Post-conditions**  
1. The title screen is displayed
___
### TC-10.2: Correct XInput Input
___
**System:** *Shootem Doods*  
**Subsystem:** Game Over  
**Created by:**    
**Executed by:**  
**Short Description:**  Tests that pressing the 'A' button on the XInput device
at the Game Over screen returns the Player to the title screen.
___

**Pre-conditions**  
* The game is running  
* The Player decided to not continue or is out of continues when they ran out of
lives.  


___


| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Press the 'A' button on the XInput device| The game returns you to the title screen|  |  ||
___
**Post-conditions**  
1. The title screen is displayed

___
### TC-10.3: Incorrect Input
___
**System:** *Shootem Doods*  
**Subsystem:** Game Over  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the Game Over screen continues to be shown if
any button other than the spacebar on the keyboard and the 'A' button on the XInput device is pressed.
___

**Pre-conditions**  
* The game is running  
* The Player decided to not continue or is out of continues when they ran out of
lives.  


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press a button that is **not** spacebar or 'A' on the XInput device | The Game Over screen is still displayed|  |  ||
___
**Post-conditions**  
1. The Game Over screen is displayed

___
## 11. Play Level
## 12. Transition Levels
### TC-12.1: Correct Input
___
**System:** *Shootem Doods*  
**Subsystem:** Transition Levels  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that, once a level is completed, the level high score is displayed until the spacebar or the 'A' button on the XInput device is pressed, then
the next level begins.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* A level has been completed  


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Complete level | The game displays the level high score|  |  |
|2         | Press spacebar or 'A' button on the XInput device | The next level starts|  |  ||
___
**Post-conditions**  
1. The next level starts

___
### TC-12.2: Incorrect Input
___
**System:** *Shootem Doods*  
**Subsystem:** Transition Levels  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that, once a level is completed, the level high
score continues to be displayed if any button other than the spacebar or the
'A' button on the XInput device is pressed.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* A level has been completed  


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Complete level | The game displays the level high score|  |  |
|2         | Press a button that is **not** the spacebar or 'A' button on the XInput device | The game displays the level high score|  |  ||
___
**Post-conditions**  
1. The level high score is displayed
___
## 13. Pause Game Menu
### TC-13.1: Keyboard Input
___
**System:** *Shootem Doods*  
**Subsystem:** Pause Game Menu  
**Created by:**    
**Executed by:**   
**Short Description:** Tests that pressing the 'M' key on the
keyboard causes the Pause Menu to appear.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* A level is currently playing and not paused


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press the 'M' key on the keyboard| The Pause Menu is displayed|  |  ||
___
**Post-conditions**  
1. The Pause Menu is displayed
___
### TC-13.2: XInput Input
___
**System:** *Shootem Doods*  
**Subsystem:** Pause Game Menu  
**Created by:**    
**Executed by:**
**Short Description:** Tests that pressing the 'Start' button on the
XInput device causes the Pause Menu to appear.  
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* A level is currently playing and not paused


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press the 'Start' button on the XInput device| The Pause Menu is displayed|  |  ||
___
**Post-conditions**  
1. The Pause Menu is displayed
___
## 14. Resume Game
### TC-14: Resume Suspended Gameplay
___
**System:** *Shootem Doods*  
**Subsystem:** Resume Game  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that selecting the 'Resume' option from the Pause
Menu resumes suspended gameplay.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* Gameplay is suspended and the Pause Menu is displayed


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Select 'Resume'| The suspended gameplay resumes|  |  ||
___
**Post-conditions**  
1. The suspended gameplay resumes
___
## 15. Collide with Objects
### TC-15: Take Damage
___
**System:** *Shootem Doods*  
**Subsystem:** Collide with Objects  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the Player's ship takes damage if it collides
with a wall, enemy, or other object.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.  
* A level is currently playing and not paused


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Navigate the Player's ship into an object | The Player's ship takes damage|  |  ||
___
**Post-conditions**  
1. The Player's ship takes damage
___
## 16. Enemy Behavior
### TC-16: Check Enemy Movement
___
**System:** *Shootem Doods*  
**Subsystem:** Enemy Behavior  
**Created by:**    
**Executed by:**
**Short Description:** Tests that the enemy begins moving along a predetermined
path once it enters the Player's view.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.  
* A level is currently playing and not paused


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Navigate the Player's ship until you see an enemy | The enemy begins moving|  |  ||
___
**Post-conditions**  
1. The enemy begins moving along a connection of straight, curved, or sinusoidal
lines.
___
## 17. Destroy Enemies
### TC-17: Check Enemy Death
___
**System:** *Shootem Doods*  
**Subsystem:** Destroy Enemies  
**Created by:**    
**Executed by:**
**Short Description:** Tests that the enemy is destroyed after being hit by a
certain amount of shots from the Player's ship and, depending on the particular
enemy's power-up drop chance, a power-up of the same color as the destroyed
enemy appears on the screen.

___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.  
* A level is currently playing and not paused


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Shoot an enemy until its hit points fall to 0 or lower | The enemy is destroyed|  |  |
|         | | A death animation is displayed|  |  |
|         |  | Either no power-up or a power-up of the same color as the enemy is displayed|  |  ||
___
**Post-conditions**  
1. The enemy is destroyed and the correct power-up or no power-up is displayed.
___
## 18. Controller Support
### TC-18.1: Check XInput Input
___
**System:** *Shootem Doods*  
**Subsystem:** Controller Support  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the system checks that a XInput compatible
controller is connected to the user's device and that the system accepts its input.

___

**Pre-conditions**  
* The user's device is on  
* The user has a XInput compatible controller plugged into their device
* The user has a keyboard plugged into their device  
* The game is running and a menu is displayed


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Plug in an XInput controller | The system recognizes the controller|  |  |
|2         | Use the XInput controller to select the begin or resume game option on the menu | A level starts/resumes|  |  |
|3         | Use the XInput controller to pause the game | The Pause Menu is displayed|  |  |
|4         | Unplug the XInput controller | The system switches to accepting keyboard input|  |  |
|5         | Use the keyboard to select the 'Resume' option on the Pause Menu | The level resumes|  |  | |

___
**Post-conditions**  
1. The keyboard is the recognized input device.
___
### TC-18.2: Check Keyboard Input
___
**System:** *Shootem Doods*  
**Subsystem:** Controller Support  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the system accepts input from a keyboard.
___

**Pre-conditions**  
* The user's device is on  
* The user has a keyboard plugged into their device  
* The game is running and a menu is displayed


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Use the keyboard to select the begin or resume game option on the menu | A level starts/resumes|  |  | |


___
**Post-conditions**  
1. The keyboard is the recognized input device.
___
## 19. Quit Application
### TC-19.1: Check 'Yes' Option
___
**System:** *Shootem Doods*  
**Subsystem:** Quit Application  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the Player is able to close the game without
having to use the operating system task manager.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* The main menu is displayed on the screen


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Select 'Exit Game'| A dialog box asking the user to confirm this action  is displayed|  |  ||
|2         | Select 'Yes' in the dialog box| The system closes the application|  |  ||
___
**Post-conditions**  
1. The application is closed
___
### TC-19.2: Check 'No' Option
___
**System:** *Shootem Doods*  
**Subsystem:** Quit Application  
**Created by:**    
**Executed by:**   
**Short Description:** Tests that the quit game confirmation box returns the user
to the main menu if they select the 'No' option.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* The main menu is displayed on the screen


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Select 'Exit Game'| A dialog box asking the user to confirm this action  is displayed|  |  ||
|2         | Select 'No' in the dialog box| The system returns the user to the main menu|  |  ||
___
**Post-conditions**  
1. The main menu is displayed
___
## 20. Save High Score
### TC-20: Check Save High Score
___
**System:** *Shootem Doods*  
**Subsystem:** Save High Score  
**Created by:**    
**Executed by:**   
**Short Description:** Tests that the system saves the Player's score if it is
higher than the current saved high score.
___

**Pre-conditions**  
* The game is running  
* The Player has either a keyboard or a valid XInput device plugged into the computer.
* A game over is achieved


___

| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Achieve a game over where the Player's score is higher than the current high score | The system recognizes the Player's score as the new high score and allows the Player to select a 3 character name| | |
|2         | Select a 3 character name | The system associates the chosen 3 character name with the new high score|  |  ||

___
**Post-conditions**  
1. The new high score is associated with the Player's chosen 3 character name.
___
