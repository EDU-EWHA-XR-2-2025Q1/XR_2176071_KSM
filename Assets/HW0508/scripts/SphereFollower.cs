using UnityEngine;

public class SphereFollower : MonoBehaviour
{
    public Transform target;  // PutTarget 또는 PutRepo

    void Update()
    {
        if (target != null)
        {
            transform.position = target.position + new Vector3(0, 0.1f, 0); // 약간 띄워서 따라가기
        }
    }
}
