
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 100f;

    public void takeDamage(float damageTaken)
    {
        health -= damageTaken;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
