using UnityEngine;
using UnityEngine.SceneManagement;

public class PickableItem : MonoBehaviour
{
    void OnMouseDown()
    {
        
        if (SceneManager.GetActiveScene().name == "Scene01")
        {
            Debug.Log($"{gameObject.name} clicked!");

            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddPick();
            }

            Destroy(gameObject);
        }
    }
}
