[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
In MG2 break-down acticity, I mapped out three game objects: player, coins, and points manager. The player will have method to jump, the coin will move constantly to the left and detect play collision, and the coin manager will spawn coins at the right of the screen and update point UI when player collision is detected. In the Unity Scene, I created an if Input statement in Update() that allow player to jump when 'space' is pressed, I also added a OnCollisionEnter2D() to detect collision with ground and update jump count to prevent multiple jumps. I then created Coin object with transform.Translate() in its Update function to move and a OnTriggerEnter2D() to call the CoinManager's AddCoin() function and destroy itself when touched by the player. It was saved a coin Prefab. As for the CoinManager, I created SpawnCoin() to create a wait time with Random.Range(0.5f, 2f) and instantiate a coin prefab when time>=waittime then resets wait time and time again. Also with AddCoin() that +1 to coincount and Updates coinText when called.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
