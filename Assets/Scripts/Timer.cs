using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        text.text = $"Survived\n{Mathf.Round(timer)}";
    }
}
