# 2dphysics
## Exercise 1
### Exercise 1a. Goblin and Zombie without physics
![exercise1a](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1a.gif)
In this example both of them are static and do not fall although they are in height. The animation still active but I cannot move it

### Exercise 1b. Goblin with physics and Zombie without it
![exercise1b](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1b.gif)
In this case, I have restored the box Collider 2d and the RigidBody 2d of the previous exercise to the goblin.The goblin can move and collide with the platforms, but when we touch the zombie, it is like it is invisible

### Exercise 1c. Goblin and Zombie with physics
![exercise1c](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1c.gif)
Now it is time to do with the Zombie, restored box Collider and RigidBody 2d. Now the goblin touch the Zombie and it dies like before

### Exercise 1d. Goblin with 10 time more mass than the Zombie
![exercise1d](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1d.gif)
Here, I have changed the value of the zombie to 300 and the goblin to 30 because it was not easy to see the difference, so now, if i do not take a run, i am not able to move the Zombie

### Exercise 1e. Goblin with physics and Zombie with isTrigger
![exercise1e](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1e.gif)
To do that step, I have removed again the rigidbody of the Zombie and create an event in the code to get in console a message if it collides with the goblin. The zombie stay as invisible but when it collides, the debug log appears.
<img width="auto" alt="image" src="https://github.com/antoniocxv/2dphysics/assets/6523949/9b2ada10-69f9-49a6-9595-3b51a7f8000a">

### Exercise 1f. Goblin and zombie with physics but Zombie with isTrigger
![exercise1f](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1f.gif)
This is the same case as before, but now the zombie does not stay in the groud, it falls, but when touch the goblin the message appears.

### Exercise 1g. Goblin and Zombie with physics but Zombie is kinematic
![exercise1g](https://github.com/antoniocxv/2dphysics/blob/main/gifs/ejercicio1g.gif)
Now the Zombie provides the collision but the goblin cannot move it like if the zombie had a big amount of mass.


## Exercise 2

a. The rock is kinematic and you cannot pass through it
b. The biggest platform gets you to the right if you stay there
c. If you move the bottom box, the other will move as they where together with Spring Joint 2d
d. two boxes collisioning and having a usual behaviour
