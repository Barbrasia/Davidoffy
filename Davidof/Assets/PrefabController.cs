using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    [SerializeField]private GameObject prefab;

    public void SpawnPrefab()
    {
        Instantiate(prefab);
    }
}
