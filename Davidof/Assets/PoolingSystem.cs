using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoolingSystem : MonoBehaviour
{
    public static PoolingSystem SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    private Rigidbody rb;
    [SerializeField] private Button _button;

    void Awake()
    {
        SharedInstance = this;
        rb = GetComponent<Rigidbody>();
        _button.onClick.AddListener(SpawnPrefab);
    }

    void Start()
    {
        //rb.useGravity = false;
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    
    public void SpawnPrefab()
    {
        Instantiate(objectToPool);
    }
}
