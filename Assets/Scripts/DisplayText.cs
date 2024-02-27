using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI warning;
    public static string content = "Press enter to start !!!";
    public static Color textColor = new Color(255, 131, 0, 255);
    void Update()
    {
        warning.text = content;
        warning.color = textColor;
    }
}
