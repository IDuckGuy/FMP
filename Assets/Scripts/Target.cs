using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;
    GameObject enemySpawnObject;

    public void TakeDamage(float amount, bool instaKill = true)
    {
        health -= amount;

        if (instaKill) health = 0;

        if(health <= 0f)
        {
            TargetDie();
        }
    }

    void TargetDie()
    {
        Destroy(gameObject);
    }
}
