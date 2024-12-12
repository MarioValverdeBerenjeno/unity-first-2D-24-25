using System.Collections;
using UnityEngine;

public class ToxicArea : MonoBehaviour
{
    [SerializeField] private float daño, duracion;
    [HideInInspector] public PlayerController player;

    private void Start()
    {
        StartCoroutine(Desactivar());
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerController playerInAera = collision.gameObject.GetComponent<PlayerController>();
        if (playerInAera != null && playerInAera == player)
            playerInAera.health -= daño / 60;
        Debug.Log("Burp damage: " + playerInAera.health);
    }

    private IEnumerator Desactivar()
    {
        yield return new WaitForSeconds(duracion);
        gameObject.SetActive(false);
    }
}
