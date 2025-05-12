using UnityEngine;

public class PutRepoMover : MonoBehaviour
{
    public Vector3 center = Vector3.zero; // ���� ��ġ
    public float radius = 0.2f;           // �̵� �ݰ�
    public float minDelay = 0.5f;
    public float maxDelay = 1.0f;

    void Start()
    {
        center = transform.localPosition;
        InvokeRepeating(nameof(MoveRandomly), 0.5f, Random.Range(minDelay, maxDelay));
    }

    void MoveRandomly()
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-radius, radius),
            Random.Range(-radius, radius),
            Random.Range(-radius, radius)
        );
        transform.localPosition = center + randomOffset;
    }
}
