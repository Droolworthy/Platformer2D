using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float number = 0.1f;

        if (collision.TryGetComponent<Player>(out Player player))
        {
            Destroy(gameObject, number);
        }
    }
}
