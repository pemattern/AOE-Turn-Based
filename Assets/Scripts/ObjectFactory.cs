using UnityEngine;

public static class ObjectFactory
{
    public static void Create<T>(Tile tile) where T : BoardObject
    {
        if (tile.GetContent() != null) throw new UnityException("Tile is not empty.");

        GameObject gameObject = new GameObject(typeof(T).Name);
        T boardObject = gameObject.AddComponent<T>();
        tile.SetContent(boardObject);
    }
}