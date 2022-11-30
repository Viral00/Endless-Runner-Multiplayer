using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private PlayerView player;
    Vector3 offset;

    private void Start()
    {
        player = GetComponent<PlayerView>();
        offset = transform.position - player.transform.position;
    }

    private void Update()
    {
        Vector3 targetPos = player.transform.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
