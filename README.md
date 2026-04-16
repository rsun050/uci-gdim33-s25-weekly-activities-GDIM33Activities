# GDIM 33 In-Class Activities
## W1
### Activity 1
1. [Inspo Board](https://docs.google.com/drawings/d/1bSd9mM2_ybX37DnfCJqedw7JUDQVw5YhKuckTEp30CI/edit?usp=sharing)

2. 
    - Patterns: a lot of platformers (Rain World, Hollow Knight, William and Sly 2), as well as relatively-simplistic looking artwork (West of Loathing, Stickfigures, Poptropica) and nonserious, silly atmospheres.
    - My tablemates like roguelikes; some roguelikes have simplistic artstyles (eg: Binding of Isaac, Brotato) similar to some of the games I like.
    - Our LA (Leah) likes RPG games like Undertale; RPGs aren't my favorite genre but I definitely did enjoy Undertale.

### Activity 2
![breakdown](https://github.com/user-attachments/assets/b1162a65-d342-4f88-a098-837df44267b3)

<hr>

## W2
Visual Scripting: 
<img width="1462" height="1321" alt="image" src="https://github.com/user-attachments/assets/e02c3b9f-09e3-447a-89d9-36c71cee7d3e" /> <br>
Grow every frame, on trigger touch (egg), play the confetti VFX <br>

<img width="1369" height="1288" alt="image" src="https://github.com/user-attachments/assets/48444b73-0d90-468e-813c-e8c96f6f2e10" /> <br>
Left/right arrow keys: movement

<img width="2014" height="610" alt="image" src="https://github.com/user-attachments/assets/b3372bf0-48a1-4384-9a12-9d2c731970b5" /> <br>
Press space: increment a counter; then Debug.Log {counter} numbers of the Fibonacci sequence.

<hr>

## W3
### Activity 1
<img width="1771" height="859" alt="breakdown3" src="https://github.com/user-attachments/assets/afd025b3-3413-4475-a5b5-eb529cb472a1" />

<!-- NOTE TO SELF: DO THE DEVLOG QUESTIONS -->
### Activity 2
1. It's convenient to save event names as Scene variables because then you don't have to type the name of the event every time another Graph wants to call the event, and if you change the event name, you don't have to change all the calls either.
2. I actually noticed my Trigger Custom Event node wasn't working because I forgot to hook up the source GameObject to the node. I noticed this because the Debug.Log in my Transition node wasn't firing.
3. I'm coding a 2D platformer with a mouse-controlled sticky hand attached to the player, so I think locking the cursor would actually be detrimental to the gameplay. I could hide the cursor if it was distracting, but locking it I think would just not work, as I need the sticky hand to constantly seek out and move towards the mouse position.
4. I don't think my game has any 'game state'. I don't intend on putting any dialogue or other 'states' that would pause movement of certain GameObjects. I could put instructions in the background of the level, but it wouldn't have any effect like the dialogue state in this week's activity.
