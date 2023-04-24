using UnityEngine;
using TMPro;

namespace GUI
{
    public class GUIStats : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI PlayerHealthText;
        [SerializeField] PlayerHealth playerHealthCom;

        private void Update()
        {
            PlayerHealthText.text = $"HP: {playerHealthCom.playerHealth}";
        }
    }
}