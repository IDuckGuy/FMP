using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey || Input.GetMouseButton(0))
            SceneManager.LoadScene("Menu");
    }
}
