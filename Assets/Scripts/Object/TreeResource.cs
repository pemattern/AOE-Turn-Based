using UnityEngine;

public class TreeResource : Resource
{
    void Start()
    {
        int prefab = Mathf.RoundToInt(Random.Range(0, _prefabs.Length - 1));
        Instantiate(_prefabs[prefab], transform);
    }
}
