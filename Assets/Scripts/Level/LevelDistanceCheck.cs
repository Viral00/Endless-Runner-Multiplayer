using UnityEngine;

public class LevelDistanceCheck : MonoBehaviour
{
    [SerializeField]private float distance;
    public GameObject player;
    public GameObject trigger;

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, trigger.transform.position);

        if (distance == 0)
        {
            SpawnManager.Instance.LevelMovement();
        }
    }
}
