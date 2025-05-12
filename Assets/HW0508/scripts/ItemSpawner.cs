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

                // 큐브를 퍼지게 생성하고 카메라 앞쪽에 두기
                item.transform.localPosition = new Vector3(
    Random.Range(-0.15f, 0.15f),   // 좌우 더 넓게 퍼짐
    0.05f + 0.1f * i,              // 위로 한 층씩 충분히 올림 (0.1은 큐브 높이만큼)
    0.3f + Random.Range(-0.1f, 0.1f)  // 앞뒤로도 살짝 흩어짐
);



                item.transform.SetParent(null);
            }
        }

        spawned = true;
    }
}
