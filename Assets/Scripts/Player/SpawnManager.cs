using UnityEngine;

public class SpawnManager : MonoSingleton<SpawnManager>
{
	public Transform[] spawnpoints;
    private LevelSpawner levelSpawner;

    private void Start()
    {
        levelSpawner = GetComponent<LevelSpawner>();
    }

    public Transform GetSpawnpoint()
	{
		return spawnpoints[Random.Range(0, spawnpoints.Length)].transform;
	}

    public void LevelMovement()
    {
        levelSpawner.MoveLevel();
    }
}
