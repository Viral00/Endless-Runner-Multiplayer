using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private ConnectToServer serverConnect;
    [SerializeField] private MenuService menuService;
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (gameObject.tag == "createRoom")
        {
            menuService.OpenMenu(MenuName.CreateRoom);
        }
    }
}
