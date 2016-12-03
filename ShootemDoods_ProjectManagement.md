___

# <p style="text-align: left;">Project Management Document</p>

</br>

### <p style="text-align: left;">for</p>

</br>

# <p style="text-align: left;">Shoot'em Doods</p>

</br>

### <p style="text-align: left;"> Version 1.0 Approved</p>

</br>

<p style="text-align: left;"> Prepared by Steven Chase Bernard, Elise Falgout,
Jacob Hinton, Brandon Kilpatrick, Jonah Knickles and David Xu</p>

</br>

<p style="text-align: left;"> CSC 4330</p>

</br>

<p style="text-align: left;"> December 2, 2016 </p>
# Table of Contents
Table of Contents

1. **Vision**
2. **Process Model**
3. **Configuration Management**  
  1. Overview of GitHub Management  
  2. Utilization of the Branching Feature
  3. Creating the Documentation  
  4. Graphs  
4. **Deliverables**  
  1. Executables  
  2. Documentation  
    1. System Requirements Specification (SRS) Document  
    2. Software Design Document (SDD)  
    3. Software Testing Document (STD)  
    4. *Shoot'em Doods*' Code   
5. **Potential Risks**
6. **Team Members**
  1. Team Style  
  2. Individual Contributions  
    1. Steven Chase Bernard  
    2. Elise Falgout  
    3. Jacob Hinton  
    4. Brandon Kilpatrick  
    5. Jonah Knickles  
    6. David Xu  

7. **Project Schedule**
8. **Meetings Summaries**  
  1. Group Meetings  
  2. Programming Team Meetings  
  3. Documentation Team Meetings  
  4. Art/Design Team Meetings  

# 1. Vision  
*Shoot'em Doods* is a new, self-contained, side-scrolling video game similar to that of the 1985 video game *Gradius*. Similar to its predecessor, the primary concept of *Shoot'em Doods* is to successfully navigate a space ship through a level by evading various enemies and obstacles with the aid of power-ups. What makes *Shoot'em Doods* unique, however, is its tri-colored power-up system.  

The three colors that *Shoot'em Doods*' power-up system uses are red, yellow, and blue. Each color indicates a different kind of ability. To elaborate, all the red power-ups are attack related, all the blue power-ups are defensive, and all the yellow power-ups pertain to utility. The idea of the color-coded power-up system is to make the game more intuitive while still adding another level of strategy to the gameplay.  

Ultimately, *Shoot'em Doods*' implementation of a tri-colored power-up system and its unique marriage of pixel art and modern graphics makes it an intriguing, thought provoking game.  

# 2. Process Model  
The process model that *Shoot'em Doods* followed was the agile method Extreme Programming (XP). Using the XP method allowed our team to create *Shoot'em Doods* incrementally while still allowing us to go back and refactor the code. Also, the pair programming facet of XP proved to be very beneficial for our programming team.  

# 3. Configuration Management  
## i. Overview of GitHub Management    
Per Professor Nash's requirements, the version control that our team used was GitHub. Most of our team has past experience with GitHub so being required to use it was not problematic for us. The team member with the most GitHub experience was Jacob Hinton so he took on the role of managing the repository by merging branches and fixing coding conflicts when they appeared.  

## ii. Utilization of the Branching Feature  
The ability to create and merge branches was a feature of GitHub that our team relied heavily upon. To elaborate, it allowed our programming team to create separate branches for each of our features and our art team to create their own art assets branch, thereby greatly minimizing any coding conflicts. Also, working on a branch that was separate from the master branch prevented us from catastrophically breaking any of the code.  

## iii. Creating the Documentation  
All of the official documentation for *Shoot'em Doods* that we posted on GitHub was done in GitHub-flavored Markdown. In the beginning, learning GitHub-flavored Markdown was a bit of a challenge for our documentation group. However, the text editor Atom (which is made by GitHub) proved to be a great help. The most helpful feature of Atom is its ability to recognize GitHub-flavored Markdown and that it allows you to preview the rendered text before uploading it to GitHub.

Working with Markdown in Atom  
![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/AtomScreenshot.png "Screenshot of Atom")

## iv. Graphs  

# 4. Deliverables  
## i. Executables  
For the first release of *Shoot'em Doods* there is an executable for the Windows, OSX, and Linux operating systems. While we did create executables for OSX and Linux, we only officially support the Windows executable at this time. New executables will be created each time a new version of *Shoot'em Doods* is released. For information on how to run the *Shoot'em Doods*' executables, please see the [readmeexe.md](https://github.com/jacobmhinton/ShootemDoods/blob/master/executables/readmeexe.md) in the folder '[executables](https://github.com/jacobmhinton/ShootemDoods/tree/master/executables)' located in the [*Shoot'em Doods*' repository](https://github.com/jacobmhinton/ShootemDoods).      
## ii. Documentation  
### a. System Requirements Specification (SRS) Document  
[*Shoot'em Doods*' System Requirements Specification document](https://github.com/jacobmhinton/ShootemDoods/blob/master/ShootemDoods_SRS.md) describes the main features of the game as precisely as possible. Our programming team then used this document as a blueprint for coding the first release of the game. As the development of *Shoot'em Doods* continues, the SRS document will continue to be revised so that it accurately depicts the functionality of the game.  

### b. Software Design Document (SDD)  
[*Shoot'em Doods*' Software Design Document](https://github.com/jacobmhinton/ShootemDoods/blob/master/ShootemDoods_SDD.md) further specifies the implementation of *Shoot'em Doods* as described in the SRS document. Its main purpose is to use diagrams and formal notations to illustrate the primary functions of *Shoot'em Doods* to its developers. The SDD will also be revised as game development continues.    

### c. Software Testing Document (STD)  
[*Shoot'em Doods*' Testing Document](https://github.com/jacobmhinton/ShootemDoods/blob/master/ShootemDoods_STD.md) details all of the test cases that need to be used in order to test the functionality of *Shoot'em Doods*. All of the test cases in the STD correspond directly to the functional requirements outlined in *Shoot'em Doods*' SRS document and its description on how they work. As *Shoot'em Doods* develops, the STD will be adjusted as needed so that it continues to accurately test the system.  

### d. *Shoot'em Doods*' Code    
Due to *Shoot’em Doods*’ open sourced nature, it was necessary for our developers to neatly document the functionality of the game’s code so that future developers will be able to understand how it works. More specifically, our programmers added header comments at the top of each file, comments on methods whose use was immediately apparent, and gave the variables meaningful names.

  Sample Header Comment  
  ![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/HeaderCommentExample.png "Sample Header Comment")  

  Sample Method Comment  
  ![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/MethodCommentExample.png "Sample Method Comment")  

# 5. Potential Risks  
The potential risks of *Shoot’em Doods* primarily pertains to time. To elaborate, many of our developers’ initial plans for *Shoot’em Doods*, such as branching level paths, might not be able to be implemented in the first release of the game because of the brevity of the allotted development time.  An additional risk that *Shoot’em Doods* faces is the possibility of an incohesive team dynamic. While many of our team members have worked well together on past projects, it is always possible that unforeseen personal circumstances/commitments will negatively impact our team dynamic and impede the development of *Shoot’em Doods*.

# 6. Team Members  
## i. Team Style  
The team style that our group decided to go with was the egoless approach. However, we did split our team up into the following subgroups:  
  1. Programming Team  
    + Jacob Hinton  
    + Brandon Kilpatrick  
    + David Xu  
  2. Art/Design Team  
    + Steven Chase Bernard  
    + Brandon Kilpatrick    
  3. Documentation Team  
    + Elise Falgout  
    + Jonah Knickles  

## ii. Individual Contributions  
The following subsections describe each team member's specific contribution to *Shoot'em Doods* as well as which team meetings they attended.
___
### a. Steven Chase Bernard  
___  

* Created art assets such as the player and enemies, as well as UI art elements
* Created animation frames for power-up abilities
* Helped with initial framework

___
### b. Elise Falgout  
___  
Elise's main role in the development of *Shoot'em Doods* was in the creation of its documentation. More specifically, she did the following:  
  + Software Requirements Specification Document (SRS)  
    - Section 2: Overall Description  
      Elise wrote this section in a Word document and sent it to Jonah Knickles via email so he could convert it into Markdown.
    - Section 3: External Interface Requirements  
      Elise wrote this section in a Word document and sent it to Jonah Knickles via email so he could convert it into Markdown. Also, please note that she outlined which images she wanted shown under 3.1 User Interfaces and that Brandon Kilpatrick and Jacob Hinton actually took the images because they had access to the most current version of the game.  
    - Added more references   
    - Proof read the final document   
  + Software Testing Document (STD)  
    - Formatted the document  
    - Section 1: Introduction  
      Elise wrote the Document Conventions subsection  
    - Section 2: Functional Requirements Test Cases  
      Elise wrote all of the test cases under subsections x. Game Over - xx. Save High Score. These subsections correspond to the functional requirements FR-10 through FR-20 that were outlined in our SRS document.  
    - Proof read the final document  
  + Project Management Document  
    - Excluding her team members' individual contribution sections, Elise wrote this document.  

___
### c. Jacob Hinton  
___  

* Team lead on programming of power-up system and all game mechanics
* Implemented all in game ui elements (power-up bar, life count, cooldown bar)
* Managed all source control through GitHub. (main responsibility here was merging when conflicts appeared)
* Contributed to the SRS document, notably on the functional requirements

___
### d. Brandon Kilpatrick  
___  

* Created and implemented art assets such as the scrolling parralax background, the Menu Screen, game control screen, and enemies
* Implemented UI elements such as the main menu, pause menu, and game-over screen
* designed and coded the behaviors of all enemy types
* designed and assembled the game test level
* Helped with documentation work, most notably the SRS document

___
### e. Jonah Knickles  
___  
My main role in the development of *Shoot'em Doods* was in the creation of its documentation. More specifically, I did the following:  
  + Software Requirements Specification Document (SRS)  
    - Table of contents and formatting
      I formatted the document.
    - Section 1
      I wrote this in Markdown.
    - Section 4: Functional requirements
      I wrote this section in Markdown. Jacob Hinton, Brandon Kilpatrick, and Elise Falgout added to and tweaked the requirements.
    - Section 5: Nonfunctional Requirements
    - I wrote this section in Markdown. Jacob Hinton, Brandon Kilpatrick, and Elise Falgout proofread it.
    - Proof read the final document
  + Software Design Document (SDD)
    - I wrote this in markdown.
    - I created the Diagrams using Dia.
    - Proofread along with Jacob Hinton, Brandon Kilpatrick, and Elise Falgout
  + Software Testing Document (STD)  
    - Section 2: Functional Requirements Test Cases  
      I wrote all of the test cases under subsections I - IX. These subsections correspond to the functional requirements FR-1 through FR-9 that were outlined in our SRS document.  
    - Proof read the final document  

___
### f. David Xu  
___  

  Implemented parts of the main game code including:

* Power-up system and mechanics of power-up effects
* Player/Enemy/Object collision and destruction
* Player input/controls

# 7. Project Schedule
## i. Critical Path Method  
| Task Description | Task | Tasks Precedence | Task Length (Days) |
| :--------------: | :--: | :---------------:| :-----------------:|
| Initial Framework| A    | None             |  3                 |
| Art              | B    | A                |  4                 |
| Mechanics        | C    | A                |  5                 |
| UI               | D    | A, B, C          |  3                 |
| Level Design     | E    | A, B, C, D       |  2                 |
| Testing          | F    | A, B, C, D, E    |  2                 |  



![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/CPM_Diagram.png "Shoot'em Doods CPM Diagram")  



| Task | Tasks Precedence | Earliest Start | Latest Start | Slack |
| :--: | :---------------:| :-------------:| :-----------:| :----:|
| A    | None             |  0             |  0           |  0    |
| B    | A                |  3             |  4           |  1    |
| C    | A                |  3             |  3           |  0    |
| D    | A, B, C          |  8             |  8           |  0    |
| E    | A, B, C, D       |  11            |  11          |  0    |
| F    | A, B, C, D, E    |  13            |  13          |  0    |
## ii. Gantt Chart  
![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/GanttChart.png "Shoot'em Doods Gantt Chart")  

# 8. Meetings Summaries  
___  


## i. Group Meetings  
### Tuesday, August 30th  
**Team Members Present:** Steven Chase Bernard, Elise Falgout, Jacob Hinton, Brandon Kilpatrick, Jonah Knickles and David Xu  
**Time:**  5:00 pm - 6:30 pm
**Summary:**  During our first official group meeting, we collectively decided that we wanted to develop a side scrolling space shooting game called *Shoot'em Doods* using the Unity Game Engine. In addition, we decided that we wanted our game to have a three way power-up system and branching level paths.  

### Tuesday, September 6th
**Team Members Present:** Steven Chase Bernard, Elise Falgout, Jacob Hinton, Brandon Kilpatrick, Jonah Knickles and David Xu   
**Time:** 5:00 pm - 5:30 pm  
**Summary:**  We discussed the talking points of our first presentation and decided that Jacob Hinton would be the presenter because he was the one who came up with the game idea.    

### Thursday, September 22nd  
**Team Members Present:** Steven Chase Bernard, Elise Falgout, Jacob Hinton, Brandon Kilpatrick, Jonah Knickles and David Xu   
**Time:** 6:00 pm - 7:30 pm  
**Summary:**  We officially delegated our team roles at the beginning of this meeting before finalizing the power-up concepts and talking about documentation.  

### Tuesday, September 27th  
**Team Members Present:** Steven Chase Bernard, Elise Falgout, Jacob Hinton, Brandon Kilpatrick, Jonah Knickles and David Xu   
**Time:**  5:00 pm - 5:45 pm  
**Summary:**  The main objective of today's meeting was to decide what our first level was going to look like. Once we finished sketching it out, we broke off into our subgroups. The programming team worked on finishing up the power-up system while the art/design team continued to flesh out the design of the first level and the documentation team discussed Assignment #1.  

### Sunday, November 27th  
**Team Members Present:**  Steven Chase Bernard, Elise Falgout, Jacob Hinton, Brandon Kilpatrick and Jonah Knickles    
**Time:** 1:00 pm - 3:30 pm  
**Summary:**  Today's meeting was purely about the final presentation on Monday, November 28th. We spent the first ten to fifteen minutes divvying up the slides and the rest of the meeting practicing our talking points with each other.   

___  


## ii. Programming Team Meetings  
### Saturday, September 3rd  
**Team Members Present:**  Steven Chase Bernard, Jacob Hinton and Brandon Kilpatrick  
**Time:**  10:30 am - 4:00 pm  
**Summary:**  Chase, Jacob, and Brandon got together to begin familiarizing themselves with the Unity Game Engine.  

### Saturday, September 10th  
**Team Members Present:**  Steven Chase Bernard, Jacob Hinton and Brandon Kilpatrick  
**Time:** 12:00 pm - 4:30 pm  
**Summary:**  During this meeting, our programming team and art/design team met up at Jacob Hinton's place to implement a moving ship, a moving camera, and add a background to a mock level.  

### Saturday, September 17th  
**Team Members Present:**  Steven Chase Bernard, Jacob Hinton and Brandon Kilpatrick  
**Time:** 10:00 am - 4:30 pm  
**Summary:**  During this meeting, our programming team and art/design team met up at Jacob Hinton's place to create object and player collisions.    

### Friday, September 23rd  
**Team Members Present:**  Jacob Hinton, Brandon Kilpatrick, and David Xu  
**Time:**  5:00 pm - 7:00 pm  
**Summary:**  The programming team got together for a pair programming session and were able to implement the basic functionality of the power-up system as well as edit the camera.     

___  


## iii. Documentation Team Meetings  
### Thursday, October 20th  
**Team Members Present:** Elise Falgout, Jacob Hinton, Brandon Kilpatrick and Jonah Knickles   
**Time:** 6:00 pm - 12:00 am  
**Summary:**  We met in the library and finished the SRS document.

___  


## iv. Art/Design Team Meetings  
### Wednesday, September 21st
**Team Members Present:** Steven Chase Bernard and Brandon Kilpatrick   
**Time:** 6:15 pm - 7:00 pm  
**Summary:**  Chase and Brandon met up at Brandon's apartment and sketched up the first design of the player's ship before creating it in Paint.net.  

  Photo of the Hand-drawn Player Ship  
  ![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/ShipMockUp1_Handdrawn.jpeg "Hand-drawn player ship")  

### Tuesday, November 15th
**Team Members Present:** Steven Chase Bernard and Brandon Kilpatrick   
**Time:** 3:00 pm - 8:00 pm  
**Summary:**  Chase finished designing some of the enemies and Brandon finished the cityscape background he has been working on.  

  Compilation of the Default Enemies  
  ![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/DefaultEnemiesMockUp.png "Compilation of the Default Enemies")  

  Finished Background Cityscape  
  ![alt text](https://github.com/jacobmhinton/ShootemDoods/blob/master/mockups/BackgroundMockUp.png "Background Cityscape")     
