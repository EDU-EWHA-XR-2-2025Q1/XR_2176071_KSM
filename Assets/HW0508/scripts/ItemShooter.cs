using UnityEngine;

public class ItemShooter : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform firePoint;
    public float shootForce = 5f;
    public Camera arCamera; // 🔄 ARCamera 연결 필요
    public Transform crosshair; // 🔄 Crosshair 연결 필요

    public void Fire()
    {
        if (itemPrefab == null || firePoint == null || arCamera == null || crosshair == null)
        {
            Debug.LogError("❌ 필수 연결 안 됨");
            return;
        }

        if (GameManager.Instance == null || GameManager.Instance.pickCount <= 0)
        {
            Debug.LogWarning("⚠ PickCount 부족");
            return;
        }

        GameObject item = Instantiate(itemPrefab, firePoint.position, Quaternion.identity);

        Rigidbody rb = item.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 direction = (crosshair.position - firePoint.position).normalized;
            rb.AddForce(direction * shootForce, ForceMode.Impulse);
        }

        GameManager.Instance.pickCount--;
    }
}
