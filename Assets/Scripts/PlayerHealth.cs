using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <=0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
