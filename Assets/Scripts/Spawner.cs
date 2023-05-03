using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] bosses;
    private int currentEnemy = 0;

    // Update is called once per frame
    private void Update() => Spawn();

    private void Spawn()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length != 0) return;

        if (currentEnemy >= bosses.Length) currentEnemy = 0;
        Instantiate(bosses[currentEnemy], transform.position, transform.rotation);
        currentEnemy++;
    }
}
