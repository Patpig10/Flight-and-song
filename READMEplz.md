Name: David Abaya

Student Number: C21326401

Class Group: None

Video: https://youtu.be/UGSFVAStWZc

# Description of the project
You'll be chasing a spaceship in the city as debris is launched into you so you have to dodge and stay on track with the ship or you'll lose. This is to simulate you flying as Superman and the background and the way the enemy attacks is affected by the tunes you add to the game.
# Instructions for use
Currently on PC: WASD to move, Q to Descend and E to Ascend
VR: Tilt both controllers to move, the left button to Ascend and the right button to Descend (Sadly, I can't do this since the VR had to be scrapped due to Github issues)
# How it works
### FlyingController:
The FlyingController script is attached to the player's game object.
It allows the player to control the movement of the object using the arrow keys (forward, backwards, left, right) and the E and Q keys for ascending and descending, respectively.

### DistanceTracker:
The DistanceTracker script is responsible for calculating and displaying the distance between the player and the enemy ship.
It references the player's and enemy ship's transforms, a TextMeshProUGUI component for displaying distance, and the EnemyShipMovement script.
It adjusts the speed of the enemy ship based on the distance. When the distance is greater than 10 units, the enemy ship's speed is tripled. If the distance is 10 units or less, the speed is reset to normal.

### EnemyShipMovement:
The EnemyShipMovement script controls the movement of the enemy ship.
The ship moves forward at a constant speed (normalSpeed).
Occasionally, the ship sways left or right (swayRange) to add variability to its movement.
It provides methods to set the speed (SetSpeed) and reset the speed to normal (ResetSpeed).

### KnockbackTrigger:
The KnockbackTrigger script handles knockback events triggered by some interaction, such as collisions.
It initiates knockback on the player controlled by the FlyingController script.
Additionally, it can lock the forward movement of the player for a specified duration.
### MusicVisualizer:
The MusicVisualizer script transforms a GameObject based on the intensity of the audio played through an AudioSource. It creates a dynamic visual effect synchronized with the music.

### SkyscraperSpawner:
The SkyscraperSpawner script generates a row of skyscrapers along a specified axis. Each skyscraper has a randomized height, width, and colour.

### SpeedBoost:
The SpeedBoost script provides a speed boost to the player when triggered by a collider. It adjusts the speed multiplier of the player's flying controller for a specified duration.

### EnemyShooter:
The EnemyShooter script handles the spawning of various projectiles from different attack points. It utilizes a coroutine to spawn projectiles at random intervals from randomly chosen attack points.

### VRPlayerController:
The VRPlayerController script provides basic movement functionality for a VR player using Unity's Input System. It allows the player to move in the scene based on input from a gamepad's left stick.

### FirstPersonCamera:
The FirstPersonCamera script provides a basic first-person camera control system in Unity. It allows the player to look around using the mouse and includes sensitivity settings, vertical angle constraints, and the ability to toggle cursor lock.
| Class/asset | Source |
|-----------|-----------|
| Spaceship armada 3D | from https://aspicprod.itch.io/spacearmada|
| Attack.cs | self written |
| SkyscraperSpawner.cs | self written |
| EnemyShooter.cs | self written |
| EnemyShipMovement.cs | self written |
| FlyingController.cs | self written |
| Effects | self written |
| Shader | self written |
|  Ride on Time - DHR | Cheeze and Pitch Invader |
| Shader | self written |
| Crash.cs | self written |
| Distancetracker.cs | self written |
| Crash.cs | self written |
| lost.cs and lost1.cs| self written |
| Crash.cs | self written |
| FirstPersonCamera.cs | self written |
| home2game.cs | self written |
| Interaction.cs | self written |
| KnockbackTrigger.cs | self written |
| MusicVisualizer.cs | self written |
| SpeedBoost.cs | self written |
| Timer.cs | self written |
| VRPlayercontroller.cs | self written |
| Crash.cs | self written |
| win.cs | self written |
# References
* Superman 64
 # What I am most proud of in the assignment
 Making objects to react to the music and getting the speed boost working though randomly give you a little boost to a large one.

# What I learned
How to make a music visualizer

Making an object that temporally boost the player's speed

Creating skyscrapers via code

# Proposal:
The player would fly towards a ship(VR or AR) using motion control. The attacks/obstacles would depend on the music you add. The building around would bounce to the tones(That's if on VR) Controls will be motion aka for VR you'll have 2 arms out and tilt the direction you want to go for AR you tilt your phone. Leaning to AR since my current laptop might not be able to handle VR and my stronger one is still getting repaired without an end in sight. Groovy on music and lighting, complex with attacks and balancing, hopefully getting a system done a week but depends on other assignments. All on unity.
