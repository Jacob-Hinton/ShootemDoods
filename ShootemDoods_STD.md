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
   TC-1.1: Correct Keyboard Input  
   TC-1.2: Correct XInput Input
   TC-1.3: Incorrect input
   2. Shoot Weapon
   TC-10.1: Correct Keyboard Input  
   TC-10.2: Correct XInput Input  
   TC-10.3: Incorrect Input
   3. Menu Navigation
   TC-3.1: Correct Keyboard Input  
   TC-3.2: Correct Xinput Input   
   TC-3.3: Incorrect Input  
   4. Collect Power-ups
   TC-4.1: Collect Powerups  
   TC-4.2: Do not collect Powerups  
   5. Use Power-ups
   TC-5.1: Use Powerups
   TC-5.2: Use no powerups
   6. Take Damage
   TC-6.1: Take Damage   
   TC-6.2: Do not take damage   
   7. Lose Life
   TC-7.1: Lose Life
   TC-7.2: Take Damage, but do not lose a life.     
   TC-7.3: Do not lose a life
   8. Use Continue
   TC-8.1: Use continue
   TC-8.2: Decline Continue
   TC-8.3: Invalid input
   9. Start Menu
   TC-9.1: Start Game
   TC-9.2: View High Scores
   TC-9.3: Quit Game
   TC-9.4: Invalid input
   10. Game Over  
   TC-10.1: Correct Keyboard Input  
   TC-10.2: Correct XInput Input  
   TC-10.3: Incorrect Input
   11. Play Level  
   TC-11.1: Level Completion  
   TC-11.2: Exit Level Manually  
   TC-11.3: Level Exited by Game Over  
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

This document details test cases to be used to test Shootem Doods. The test cases are formed with Black box testing.

## 2. Document Conventions

The template shown in class was used to form these test cases

# **Functional Requirements Test Cases**
## i. Move Player

___
### TC-1.1: Correct Keyboard Input
___
**System:** *Shootem Doods*  
**Subsystem:** None
**Created by:**    
**Executed by:**  
**Short Description:**  Tests that pressing the 'WASD' buttons on keyboard during Gameplay moves the player.
___

**Pre-conditions**  
* The game is running  
* The player has started gameplay.


___


| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Press the 'W' button on the Keyboard| The Player character moves up. |  |  ||
|2         | Press the 'A' button on the Keyboard| The Player character moves left. |  |  ||
|3         | Press the 'S' button on the Keyboard| The Player character moves right. |  |  ||
|4         | Press the 'D' button on the Keyboard| The Player character moves down. |  |  ||
___
**Post-conditions**  
1. The character should be still after all buttons are released.

___
### TC-1.2: Correct XInput Input
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level
**Created by:**    
**Executed by:**  
**Short Description:**  Tests that moving the analog stick and pressing the Directional buttons on the XInput device moves the player.
___

**Pre-conditions**  
* The game is running  
* The player has started gameplay.


___


| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Press up on directional pad of the the XInput device| The Player character moves up. |  |  ||
|2         | Press down on directional pad ofthe XInput device| The Player character moves left. |  |  ||
|3         | Press right on directional pad of theXInput device| The Player character moves right. |  |  ||
|4         | Press down on directional pad of the XInput device| The Player character moves down. |  |  ||
|5         | Move the left analog stick on the XInput device in a circle. | The Player character moves in a circle |  |  ||
___
**Post-conditions**  
1. The character should be still after all buttons are released.


___
### TC-1.3: Incorrect Input
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the Player Character remains still if any  W,A,S, or D on the keyboard or the left analog stick or Directional pad on the XInput device is pressed.
___

**Pre-conditions**  
* The game is running  
* The player should have chosen to initiate gameplay

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press a button that is **not** W,A,S, or D on the keyboard or the left analog stick or Directional pad on the XInput device | The Player Character does not move|  |  ||
___
**Post-conditions**  
1. The Player character should not have moved as outlined in Move Player.


## ii. Shoot Weapon

___
### TC-2.1: Correct Keyboard Input
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level  
**Created by:**    
**Executed by:**  
**Short Description:**  Tests that pressing the spacebar on keyboard during Gameplay shoots the player's weapon.
___

**Pre-conditions**  
* The game is running  
* The player has started gameplay.


___


| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Press the spacebar on the Keyboard| The Player character  shoots. |  |  ||
___
**Post-conditions**  
1. The character should be still after all buttons are released.

___
### TC-2.2: Correct XInput Input
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level  
**Created by:**    
**Executed by:**  
**Short Description:**  Tests that pressing the 'A' Button on the XInput Device during Gameplay shoots the player's weapon.
___

**Pre-conditions**  
* The game is running  
* The player has started gameplay.


___


| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Press the 'A' Button on the Xinput Device| The Player character  shoots. |  |  ||
___
**Post-conditions**  
1. The character should be still after all buttons are released.

___
### TC-2.3: Incorrect Input
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level  
**Created by:**    
**Executed by:**  
**Short Description:** Tests that the Player Character remains still if anything other than W or D on the keyboard or up and down on the left analog stick or Directional pad on the XInput device is pressed.
___

**Pre-conditions**  
* The game is running  
* The player has not started gameplay or has paused the game.

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press a button that is **not** W,A,S, or D on the keyboard or the left analog stick or Directional pad on the XInput device | The Player Character does not move|  |  ||
___
**Post-conditions**  
1. The Player character should not have moved as outlined in Move Player.

## iii. Menu Navigation
___
### TC-3.1: Correct Keyboard Input
___
**System:** *Shootem Doods*  
**Subsystem:** Menus

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that pressing the spacebar on keyboard during Gameplay shoots the player's weapon.
___

**Pre-conditions**  
* The game is running  
* The player has not started gameplay or has paused the game.


___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Press the down on the Keyboard| The cursor of the menu moves down. |  |  ||
|2         | Press the up on the Keyboard| The cursor of the menu moves up. |  |  ||
___
**Post-conditions**  
1. The cursor should be still after all buttons are released.

### TC-3.2: Correct Xinput Input
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level

**Created by:**    
**Executed by:**  
**Short Description:** Tests that the menu's response to if a W,D, or Enter on the keyboard or up or down on the directional pad, up or down on the left Analog stick, or 'A' on the Xinput Device.
___

**Pre-conditions**  
* The game is running  
* The Player has not decided to initiate Gameplay.  

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press the down on the Directional pad of the Xinput device| The cursor of the menu moves down. |  |  ||
|2         | Press the up on the Direction pad of the Xinput device.| The cursor of the menu moves up. |  |  ||
|3         | Press the down on the left analog stick of the Xinput device| The cursor of the menu moves down. |  |  ||
|4         | Press the up on the left analog stick of the Xinput device| The cursor of the menu moves up. |  |  ||
|5         | Press the up on the left analog stick of the Xinput device| The cursor of the menu moves up. |  |  ||
___
**Post-conditions**  
1. The cursor should be still once all buttons are released.


### TC-3.3: Incorrect Input
___
**System:** *Shootem Doods*  
**Subsystem:** Menus

**Created by:**    
**Executed by:**  
**Short Description:** Tests that the Cursor remains still if anything other than W or D on the keyboard or up and down on the left analog stick or Directional pad on the XInput device is pressed.
___

**Pre-conditions**  
* The game is running  
* The player has not started gameplay or has paused the game.

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press a button that is **not** W,A,S, or D on the keyboard or the left analog stick or Directional pad on the XInput device | The Player Character does not move|  |  ||
___
**Post-conditions**  
1. The Player character should not have moved as outlined in Move Player.


## iv. Collect Power-ups

___
### TC-4.1: Collect Powerups
___
**System:** *Shootem Doods*  
**Subsystem:**  Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that Collecting powerups collects powerups.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay


___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Run into a powerup in the level| The powerup is added to the player's powerup bar. |  |  ||
___
**Post-conditions**  
1. The player should have a powerup


___
### TC-4.2: Do not collect Powerups
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that not hitting powerups does not collect powerups.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay

___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Play through the level without collecting powerups| The player should not have powerups. |  |  ||
___
**Post-conditions**  
1. The player should not have any powerups


## v. Use Power-ups


___
### TC-5.1: Use Powerups
___
**System:** *Shootem Doods*  
**Subsystem:** Menus

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that pressing 'E' on the keyboard or Right Bumper on the Xinput device during Gameplay uses collected powerups.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start Gameplay.


___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Run into a powerup| The powerup is added to the player's inventory |  |  ||
|2         | Press 'E' on the keyboard or Right Bumper on the Xinput device to use powerup|The powerups in the player's inventory are used. |  |  ||
___
**Post-conditions**  
1. The powerups should have activated.


___
### TC-5.2: Use no powerups
___
**System:** *Shootem Doods*  
**Subsystem:** Menus

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that not pressing 'E' on the keyboard or Right Bumper on the Xinput device during Gameplay does not use powerups.
___

**Pre-conditions**  
* The game is running  
* The player has started gameplay.


___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Run into a powerup during Gameplay| The powerup is collected. |  |  ||
|2         | Do not press 'E' on the keyboard or the Right Bumper on an Xinput device. | Nothing |  |  ||
___
**Post-conditions**  
1. No powerups should be used



## vi. Take Damage
___
### TC-6.1: Take Damage
___
**System:** *Shootem Doods*  
**Subsystem:**  Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that hitting damage sources causes damage to the player.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay


___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Run into an enemy, projectile, object, or wall in the level| The player should take damage. |  |  ||
___
**Post-conditions**  
1. The player should take damage.

___
### TC-6.2: Do not take damage
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that not hitting damage sources does not cause damages.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay

___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Play through the level without being hit by enemy projectiles, objects, or walls| The player should not have taken damage. |  |  ||
___
**Post-conditions**  
1. The player should not have taken damage


## vii. Lose Life
___
### TC-7.1: Lose Life
___
**System:** *Shootem Doods*  
**Subsystem:**  Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that hitting damage sources causes damage to the player.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay
* The player has no actve powerups

___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Run into an enemy, projectile, object, or wall in the level| The player should take damage. |  |  ||
___
**Post-conditions**  
1. The player should take damage and lose a life.

___
### TC-7.2: Take Damage, but do not lose a life.
___
**System:** *Shootem Doods*  
**Subsystem:**  Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that hitting damage sources while powered up causes damage to the player and does not decrement the life counter.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay


___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Run into a powerup| The powerup is added to the player's inventory |  |  ||
|2         | Press 'E' on the keyboard or Right Bumper on the Xinput device to use powerup|The powerups in the player's inventory are used. |  |  ||
|3         | Run into an enemy, projectile, object, or wall in the level| The player should take damage. |  |  ||
___
**Post-conditions**  
1. The player should take damage, but not lose a life.
___
### TC-7.3: Do not lose a life
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level

**Created by:**    
**Executed by:**  
**Short Description:**  Tests that not hitting damage sources does not cause damage or cause the player to lose a life.
___

**Pre-conditions**  
* The game is running  
* The player has chosen to start gameplay

___

| Step     | Action         |Expected System Response| Pass/Fail | Comment |
| :------: | :------------- | :----------------------| :-------: | :-------|
|1         | Play through the level without being hit by enemy projectiles, objects, or walls.| The player should not have taken damage. |  |  ||
___
**Post-conditions**  
1. The player should not have taken damage, and should not have lost a life.


## viii. Use Continue
### TC-8.1: Use continue
___
**System:** *Shootem Doods*  
**Subsystem:** Continue

**Created by:**    
**Executed by:**    
**Short Description:** Tests that pressing the spacebar on the keyboard or the 'A' button on the Xinput device to select the yes option uses a continue.
___

**Pre-conditions**  
* The game is running  
* The Player  ran out of lives.


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press the spacebar on the keyboard or 'A' on the Xinput device. | The game returns you to the beginning of the level|  |  ||
___
**Post-conditions**  
1. The level restarts from the beginning
___

### TC-8.2: Decline Continue
___
**System:** *Shootem Doods*  
**Subsystem:** Continue

**Created by:**    
**Executed by:**    
**Short Description:** Tests that selecting the 'no' option at the continue screen declines continues
___

**Pre-conditions**  
* The game is running  
* The Player ran out of lives.


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press 'D' or left on the left analog stick or Directional pad. | The cursor goes to the "No" option. |  |  ||
|2         | Press the spacebar or 'A'. | The game declines use of a continue, and begins the game over sequence. |  |  ||
___
**Post-conditions**  
1. The Game Over sequence initiates.
___

### TC-8.3: Invalid input
___
**System:** *Shootem Doods*  
**Subsystem:** Continue

**Created by:**    
**Executed by:**    
**Short Description:** Tests that pressing the spacebar on the keyboard or the 'A' button on the Xinput device to select the yes option uses a continue.
___

**Pre-conditions**  
* The game is running  
* The Player  ran out of lives.


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press anything other than the spacebar on the keyboard or 'A' on the Xinput device. | The game should not respond. |  |  ||
___
**Post-conditions**  
1. The Continue screen continues to be displayed
___

## ix. Start Menu    
### TC-9.1: Start Game
___
**System:** *Shootem Doods*  
**Subsystem:** Continue

**Created by:**    
**Executed by:**    
**Short Description:** Tests that pressing the spacebar on the keyboard or the 'A' button on the Xinput device to select the yes option uses a continu.
___

**Pre-conditions**  
* The game is running  
* The Player is at the start menu.

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press the spacebar on the keyboard or 'A' on the Xinput device. | The game Starts the first level|  |  ||
___
**Post-conditions**  
1. The level restarts from the beginning
___

### TC-9.2: View High Scores
___
**System:** *Shootem Doods*  
**Subsystem:** Start Menu

**Created by:**    
**Executed by:**    
**Short Description:** Tests that selecting the 'View High Scores' option at the Start Menu shows High Scores.
___

**Pre-conditions**  
* The game is running  
* The Player is at the start menu.

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press 'S' or Down on the left analog stick or Directional pad. | The cursor goes to the "View High Scores" option. |  |  ||
|2         | Press the spacebar or 'A'. | The game shows the High scores. |  |  ||
___
**Post-conditions**  
1. The High Scores are shown.
___


### TC-9.3: Quit Game
___
**System:** *Shootem Doods*  
**Subsystem:** Start Menu

**Created by:**    
**Executed by:**    
**Short Description:** Tests that selecting the 'Quit Game' option at the Start Menu exits the game.
___

**Pre-conditions**  
* The game is running  
* The Player is at the start menu.

___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press 'S' or Down on the left analog stick or Directional pad. | The cursor goes to the "View High Scores" option. |  |  ||
|2         | Press 'S' or Down on the left analog stick or Directional pad. | The cursor goes to the "Quit Game" option. |  |  ||
|3         | Press the spacebar or 'A' on the Xinput device. | The game exits. |  |  ||
___
**Post-conditions**  
1. The game is not running.
___

### TC-9.4: Invalid input
___
**System:** *Shootem Doods*  
**Subsystem:** Start Menu

**Created by:**    
**Executed by:**    
**Short Description:** Tests that pressing anything other than A,D, or the spacebar on the keyboard or up and down on the directional pad or left analog stick or the 'A' button on the Xinput device does nothing.
___

**Pre-conditions**  
* The game is running  
* The Player is at the start menu.


___


| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Press anything other than A,D, or the spacebar on the keyboard or up and down on the directional pad or left analog stick or the 'A' button on the Xinput device. | The game should not respond. |  |  ||
___
**Post-conditions**  
1. The Start menu continues to be displayed
___


## x. Game Over
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
## xi. Play Level  
### TC-11.1: Level Completion
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level  
**Created by:**    
**Executed by:**    
**Short Description:** Tests that a level starts and continues until gameplay is ended by level completion.
___

**Pre-conditions**  
* The game is running  
* An event that begins a level (level transition or game start) has occurred.


___
| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Navigate the Player's ship through the level| The level continues running|  |  |
|2         | Reach the end of the level | The system exits the level and loads the next level|  |  ||
___
**Post-conditions**  
1. The next level is loaded
___

### TC-11.2: Exit Level Manually
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level  
**Created by:**    
**Executed by:**    
**Short Description:** Tests that a level starts and continues until gameplay is ended manually.
___

**Pre-conditions**  
* The game is running  
* An event that begins a level (level transition or game start) has occurred.


___
| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Navigate the Player's ship through the level| The level continues running|  |  |
|2         | Press either the 'M' key on the keyboard or the 'Start' button on a XInput device | The Pause Menu is displayed and the level is suspended|  |  |
|3         | Select 'Quit to Start Screen' | The title screen is shown|  |  ||
___
**Post-conditions**  
1. Game play is ended and the title screen is shown.
___
### TC-11.3: Level Exited by Game Over
___
**System:** *Shootem Doods*  
**Subsystem:** Play Level  
**Created by:**    
**Executed by:**    
**Short Description:** Tests that a level starts and continues until gameplay is ended by a game over.
___

**Pre-conditions**  
* The game is running  
* An event that begins a level (level transition or game start) has occurred.


___
| Step     | Action            |Expected System Response| Pass/Fail | Comment |
| :------: | :---------------- | :----------------------| :-------: | :-------|
|1         | Navigate the Player's ship through the level| The level continues running|  |  ||
|2         | Collide with objects or get hit by enemy ships until all lives are lost | The system exits the level and the Game Over screen is displayed|  |  ||
___
**Post-conditions**  
1. The Game Over screen is displayed.
___
## xii. Transition Levels
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
## xiii. Pause Game Menu
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
## xiv. Resume Game
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
## xv. Collide with Objects
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
## xvi. Enemy Behavior
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
## xvii. Destroy Enemies
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
## xviii. Controller Support
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
## xix. Quit Application
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
## xx. Save High Score
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
