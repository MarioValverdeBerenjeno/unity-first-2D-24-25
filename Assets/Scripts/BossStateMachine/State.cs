using UnityEngine;


public class State : IState
{
    private Vector3 offset = new(1, 1, 0);
    protected BossController Boss;
    private Vector2 PlayerDistance;

    public State(BossController Boss)
    {
        this.Boss = Boss;
    }

    public virtual void Entry()
    {
        // dejar que el estado lo cambie
    }

    public virtual void Exit()
    {
        // dejar que el estado lo cambie
    }

    public virtual void Update()
    {
        // calcular distancia al jugador
        // reducir vida
        Boss.currentHealth -= 0.01f;
        FollowPlayer();
        // dejar que cada estado lo cambie
    }

    private void FollowPlayer()
    {
        Vector3 targetPosition = Boss.Player.transform.position + offset;
        if (!float.IsNaN(targetPosition.x) && !float.IsNaN(targetPosition.y) && !float.IsNaN(targetPosition.z))
            Boss.transform.position = Vector3.MoveTowards(Boss.transform.position, targetPosition, 0.05f * Boss.speed * Time.deltaTime);
    }
}
