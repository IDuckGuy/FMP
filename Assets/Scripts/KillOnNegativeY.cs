using UnityEngine;
using UnityEngine.SceneManagement;

public class KillOnNegativeY : MonoBehaviour
{
    // Kill if y is less than -5
    private void Update()
    {
        if (transform.position.y < -5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}