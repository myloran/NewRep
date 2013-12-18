var spawnPoints : Transform[];  // Array of spawn points to be used.
var enemyPrefabs : GameObject[]; // Array of different Enemies that are used.
var amountEnemies = 20;  // Total number of enemies to spawn.


function Start()
{
    Spawn();
}

function Spawn() 
{ 
   for (i=0; i<amountEnemies; i++) // How many enemies to instantiate total.
   {
      var obj : GameObject = enemyPrefabs[Random.Range(0, enemyPrefabs.length)]; // Randomize the different enemies to instantiate.
      var pos: Transform = spawnPoints[Random.Range(0, spawnPoints.length)];  // Randomize the spawnPoints to instantiate enemy at next.

      Instantiate(obj, pos.position, pos.rotation); 
   } 
}  