using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public List<GameObject> road;
    private float offset = 50f;

    private void Start()
    {
        if (road != null && road.Count > 0)
        {
            road = road.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveLevel()
    {
        GameObject movedRoad = road[0];
        road.Remove(movedRoad);
        float newZ = road[road.Count - 1].transform.position.z + offset;
        movedRoad.transform.position = new Vector3(0, 0, newZ);
        road.Add(movedRoad);
    }
}
