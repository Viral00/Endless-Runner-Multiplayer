using UnityEngine;

[RequireComponent(typeof(PlayerView))]
public class PlayerStates : MonoBehaviour
{
    protected PlayerView playerView;

    public void Start()
    {
        playerView = GetComponent<PlayerView>();
    }

    public virtual void OnEnterState()
    {
        this.enabled = true;
    }
    public virtual void OnExitState()
    {
        this.enabled = false;
    }

}
