using UnityEngine;

public class SphereFollower : MonoBehaviour
{
    public Transform target;  // PutTarget �Ǵ� PutRepo

    void Update()
    {
        if (target != null)
        {
            transform.position = target.position + new Vector3(0, 0.1f, 0); // �ణ ����� ���󰡱�
        }
    }
}
