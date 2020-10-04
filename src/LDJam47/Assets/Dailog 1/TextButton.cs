
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TextButton : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }
}
