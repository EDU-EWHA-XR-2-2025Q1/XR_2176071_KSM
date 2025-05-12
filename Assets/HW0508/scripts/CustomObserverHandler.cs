using UnityEngine;
using Vuforia;

public class CustomObserverHandler : MonoBehaviour
{
    public GameObject uiGroup;

    private ObserverBehaviour observer;

    private void Start()
    {
        if (uiGroup != null)
            uiGroup.SetActive(false);  // UIGroup이 있을 때만 꺼줌
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

        // Target 인식 시 아이템 스폰
        ItemSpawner spawner = GetComponentInChildren<ItemSpawner>();
        if (isTracking && spawner != null)
            spawner.SpawnItems();

        // UIGroup이 있을 때만 UI 제어
        if (uiGroup != null)
            uiGroup.SetActive(isTracking);
    }
}
