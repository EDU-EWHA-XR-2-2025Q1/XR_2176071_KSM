using UnityEngine;
using Vuforia;

public class CustomObserverHandler : MonoBehaviour
{
    public GameObject uiGroup;

    private ObserverBehaviour observer;

    private void Start()
    {
        if (uiGroup != null)
            uiGroup.SetActive(false);  // UIGroup�� ���� ���� ����
    }

    private void OnEnable()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer != null)
            observer.OnTargetStatusChanged += OnStatusChanged;
    }

    private void OnDisable()
    {
        if (observer != null)
            observer.OnTargetStatusChanged -= OnStatusChanged;
    }

    private void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool isTracking = status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED;

        // Target �ν� �� ������ ����
        ItemSpawner spawner = GetComponentInChildren<ItemSpawner>();
        if (isTracking && spawner != null)
            spawner.SpawnItems();

        // UIGroup�� ���� ���� UI ����
        if (uiGroup != null)
            uiGroup.SetActive(isTracking);
    }
}
