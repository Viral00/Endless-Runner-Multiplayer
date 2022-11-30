using UnityEngine;

public class LevelDistanceCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        SpawnManager.Instance.LevelMovement();
    }
}
