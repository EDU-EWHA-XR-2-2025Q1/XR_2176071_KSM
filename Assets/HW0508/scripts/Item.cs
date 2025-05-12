using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemIndex;

    private void OnMouseDown()
    {
        GameManager.Instance.itemAlive[itemIndex] = false;
        GameManager.Instance.AddPick();
        Destroy(gameObject);
    }
}
