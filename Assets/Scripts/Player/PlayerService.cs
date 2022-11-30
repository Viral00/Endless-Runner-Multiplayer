using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerService : MonoBehaviourPunCallbacks
{
    PhotonView PV;
    private Transform spawnpoint;

    protected void Awake()
    {
        spawnpoint = SpawnManager.Instance.GetSpawnpoint();
        PV = GetComponent<PhotonView>();
    }

    private void Start()
    {   
        if (PV.IsMine)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), spawnpoint.position, Quaternion.identity);
        }
        
    }
}
