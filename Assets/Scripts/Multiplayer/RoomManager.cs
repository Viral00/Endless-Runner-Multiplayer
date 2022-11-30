using UnityEngine;
using Photon.Pun;
using System.IO;
using UnityEngine.SceneManagement;

public class RoomManager : MonoSingleton<RoomManager>
{
    protected override void Awake()
    {
		base.Awake();
		DontDestroyOnLoad(gameObject);
    }
    public override void OnEnable()
	{
		base.OnEnable();
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	public override void OnDisable()
	{
		base.OnDisable();
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
	{
		if (scene.buildIndex == 1)
		{
			PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerService"), Vector3.zero, Quaternion.identity);
		}
	}
}
