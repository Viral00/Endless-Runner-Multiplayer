using UnityEngine;

public class Menu : MonoBehaviour
{
	public MenuName menuNum;
	[HideInInspector]public bool open;

	public void Open()
	{
		open = true;
		gameObject.SetActive(true);
	}

	public void Close()
	{
		open = false;
		gameObject.SetActive(false);
	}
}

public enum MenuName
{
	None,
	Title,
	Loading,
	FindRoom,
	CreateRoom,
	Room,
	error
}
