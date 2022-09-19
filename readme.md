# Week 5 - Perspective (and review of Week 4 - Behaviors)

## Slides / Manual

https://myuva-my.sharepoint.com/:p:/g/personal/jcb2h_virginia_edu/EfUbW-a-nTJDh-vlYPTIhKIBZrCmWnVIP8pgKTL9ISqp4g?e=b9Zwq7
https://docs.unity3d.com/Manual/CamerasOverview.html

## Level

1. There are 10 "Broken Scenes" in the "Broken Scenes" folder
	* Broken Scenes 1-8 have ONE thing wrong (although sometimes that one thing is wrong on multiple GameObjects, or a similar problem twice within a single script)
	* Broken Scenes 9-10 have TWO things wrong 
	* The problems are CUMULATIVE, so whatever you fix in Broken Scene 1, you'll also have to fix again in Broken Scene 2 and so forth (the goal here is to teach you through repetition, which is super annoying we know...)
		* ***The only exception to this is Broken Scene 6***, which doesn't have Broken Scene 5's problem because it would cause confusion
	* ### No Scripting Needed in 1-5!
		* Broken Scenes 1-5 do NOT have anything wrong with the SCRIPTS-- you should be able to fix them WITHOUT touching code
	* ### Scripting Needed in 6-10!
		* Broken Scenes 6-10 DO have broken SCRIPTS that you will have to fix (with Visual Studio's help) 
		* Make sure you open the scripts used in that scene (e.g. **MoveObject6.cs**, with a "6" on the end, not MoveObject.cs, without it)
		* Every time you fix something in a script, write a comment explaining what you did and why you did it (e.g. // I changed the FIELD TYPE to GameObject because...)
		* Just because they are broken DOES NOT mean they will have errors... they may be SYNTACTICALLY correct, but still not functional the way we want them to function
		* For scripts that DO have SYNTAX errors, I've commented out the whole script. This is due to the fact that Unity won't run ANY scenes if a script is broken in the project.
			* You can uncomment multiple lines by clicking and dragging to select those lines, then going to Edit > Advanced > Uncomment Selection 
			* There is also a shortcut button located here:
			![image](https://user-images.githubusercontent.com/7291792/191106477-d73b0d19-df5f-4356-922c-beef74b0dd9d.png)
		* It is NOT considered cheating to look at other, working scripts to see what is different, BUT it might be useful to try and puzzle it out for a while before comparing to other scripts

2. Once you finish #1, add a third person perspective to the game
3. Add a large object that is outside the Clipping Plane of the third person perspective
4. Figure out a way so show the player that this object is large and far away (instead of small and close)

*Bonus Challenge / Mini Boss* Can you figure out how to make the other red cubes "Selectable" in the SampleScene? 

## Bosses

No bosses this week, start working on a concept for your "Escape Room" game. 

OR, if you don't have a concept, start planning out what parts you'll need. 

If you'd like, go ahead and start building it. Keep in mind what we've read and played thus far, and what a "literary" game might include.
