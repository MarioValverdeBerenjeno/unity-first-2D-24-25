using System.Collections;
using UnityEngine;

public class RageState : State
{
    public RageState(BossController Boss) : base(Boss) {}

    public override void Entry()
    {
        base.Entry();
        Debug.Log("Rage State Entered");
        Boss.StartCoroutine(EnterBurp());
    }

    private IEnumerator EnterBurp()
    {
        yield return new WaitForSeconds(2f);
        Boss.ChangeStateKey(States.Burp);
    }
}
