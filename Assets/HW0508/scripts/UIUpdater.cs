using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI pickText;
    public TextMeshProUGUI putText;

    void Update()
    {
        //pickText.text = "Pick: " + GameManager.Instance.pickCount;
        //putText.text = "Put: " + GameManager.Instance.putCount;
        if (GameManager.Instance != null && pickText != null && putText != null)
        {
            pickText.text = "Pick: " + GameManager.Instance.pickCount;
            putText.text = "Put: " + GameManager.Instance.putCount;
        }
        else
        {
            Debug.LogWarning("UIUpdater: GameManager.Instance or TMP Text not set.");
        }
    }
}
