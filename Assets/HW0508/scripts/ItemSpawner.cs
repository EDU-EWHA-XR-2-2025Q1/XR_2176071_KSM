using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform spawnRoot;

    private bool spawned = false;

    public void SpawnItems()
    {
        if (spawned) return; // Prevent double spawn

        for (int i = 0; i < 10; i++)
        {
            if (GameManager.Instance.itemAlive[i])
            {
                GameObject item = Instantiate(itemPrefab);
                item.transform.SetParent(spawnRoot, false);
                item.name = "Item_" + i;

                // ť�긦 ������ �����ϰ� ī�޶� ���ʿ� �α�
                item.transform.localPosition = new Vector3(
    Random.Range(-0.15f, 0.15f),   // �¿� �� �а� ����
    0.05f + 0.1f * i,              // ���� �� ���� ����� �ø� (0.1�� ť�� ���̸�ŭ)
    0.3f + Random.Range(-0.1f, 0.1f)  // �յڷε� ��¦ �����
);



                item.transform.SetParent(null);
            }
        }

        spawned = true;
    }
}
