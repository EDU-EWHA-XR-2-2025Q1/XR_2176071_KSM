using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class PutRepoObject : MonoBehaviour
{
    public float radius = 0.05f;
    public float minDelay = 0.5f;
    public float maxDelay = 1.0f;

    private Vector3 center;

    void Start()
    {
        center = transform.position; // world 기준
        StartCoroutine(MoveRoutine());
    }

    private IEnumerator MoveRoutine()
    {
        while (true)
        {
            MoveRandomly();
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        }
    }

    private void MoveRandomly()
    {
        Vector3 offset = new Vector3(
            Random.Range(-radius, radius),
            Random.Range(-radius, radius),
            Random.Range(-radius, radius)
        );

        transform.position = center + offset; // world 기준 이동
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            GameManager.Instance?.AddPut();
        }
    }
}
