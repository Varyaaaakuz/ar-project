using UnityEngine;
using System;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class ArButton : MonoBehaviour
{

    public event Action OnButtonClicked;

    [SerializeField] private TextMeshPro _title;
    [SerializeField] private Interactable _interactable;

    private GameObject _prefab;

    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.Prefab;

        _interactable.OnClick.AddListener(ProcessClick);
    }

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        SpawnItem();
    }
    public void SpawnItem()
    {
        Instantiate(_prefab, new Vector3(1, 0, 0), Quaternion.identity);
    }
}
