using UnityEngine;

public class TreeResource : ResourceObject
{
    void Start()
    {
        int prefab = Mathf.RoundToInt(Random.Range(0, 2));
        Instantiate(_prefabs[prefab], transform);
    }
}
