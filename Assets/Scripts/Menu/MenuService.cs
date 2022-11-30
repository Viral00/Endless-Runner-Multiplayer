using UnityEngine;

public class MenuService : MonoSingleton<MenuService>
{
	[SerializeField] Menu[] menus;
	public void OpenMenu(MenuName menu)
	{
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i].menuNum == menu)
			{
				menus[i].Open();
			}
			else if (menus[i].open)
			{
				CloseMenu(menus[i]);
			}
		}
	}

	public void OpenMenu(Menu menu)
	{
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i].open)
			{
				CloseMenu(menus[i]);
			}
		}
		menu.Open();
	}

	public void CloseMenu(Menu menu)
	{
		menu.Close();
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
