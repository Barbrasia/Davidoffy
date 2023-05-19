using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabController : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Button _button;
    private GameObject[] _prefabsOnScene = new GameObject[5];
    [SerializeField] private Vector3 _currentPosition;
    [SerializeField] private Vector3 _offset;
    private int _prefabCount = 0;


    
    private void Awake()
    {
        _button.onClick.AddListener(AddPrefab);
        for (int i = 0; i < 5; i++)
        {
            _prefabsOnScene[i] = SpawnPrefab();
        }
    }

    public GameObject SpawnPrefab()
    {
        GameObject prefab = Instantiate(_prefab, _currentPosition, Quaternion.identity);
        _currentPosition += _offset;
        return prefab;
    }

    private void AddPrefab()
    {
        _prefabsOnScene[_prefabCount].transform.position = _currentPosition;
        _currentPosition += _offset;
        _prefabCount++;

        if (_prefabCount > 5)
            _prefabCount = 0;
    }
}
