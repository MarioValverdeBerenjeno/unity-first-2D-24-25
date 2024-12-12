using UnityEngine;

public class RageState : State
{
    public RageState(BossController Boss) : base(Boss) {}

    public override void Entry()
    {
        base.Entry();
        Debug.Log("Rage State Entered");
        Boss.ChangeStateKey(States.Burp);
    }
}
