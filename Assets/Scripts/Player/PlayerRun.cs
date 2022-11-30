using UnityEngine;

public class PlayerRun : PlayerStates
{
    private PlayerView playerview;
    
    public override void OnEnterState()
    {
        base.OnEnterState();
        playerview.isRun = true;
    }

    public override void OnExitState()
    {
        base.OnExitState();
        playerview.isRun = false;
    }
    private void Awake()
    {
        playerview = GetComponent<PlayerView>();
    }
}