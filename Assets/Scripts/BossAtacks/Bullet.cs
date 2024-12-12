using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float daño, velocidad;

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        transform.position += velocidad * Time.deltaTime * Vector3.left;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if(player != null)
        {
            player.health -= daño;
            Debug.Log(player.health);
            Destroy(gameObject);
        }
    }
}
