using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private void Start()
    {
        SpawnObstacle();
    }

    public void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(0, 2);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
    }
}
