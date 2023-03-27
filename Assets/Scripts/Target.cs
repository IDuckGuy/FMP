using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    GameObject enemySpawnObject;

    private void start()
    {
        enemySpawnObject = GameObject.Find("Spawner");
    }
    public void TakeDamage(float amount, bool instaKill = true)
    {
        health-= amount;

        if (instaKill) health = 0;

        if(health <= 0f)
        {
            TargetDie();
        }
    }

    void TargetDie()
    {
        // enemySpawnObject.GetComponent<EnemySpawn>().numberOfEnemies--;
        // EnemySpawn.Instance.numberOfEnemies--;
        Destroy(gameObject);
    }
}
