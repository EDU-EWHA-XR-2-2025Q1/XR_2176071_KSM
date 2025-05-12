using UnityEngine;

public class ItemProjectile : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PutRepo"))
        {
            Debug.Log("Item reached PutRepo!");
            if (GameManager.Instance != null)
                GameManager.Instance.AddPut();

            Destroy(gameObject);  // Remove the projectile
        }
    }
}
