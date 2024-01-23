using UnityEngine;

public class Board : MonoBehaviour
{
    const int SIZE = 10;
    private Tile[,] _tiles;

    private void Start()
    {
        _tiles = InitializeTiles();
        transform.localEulerAngles = new Vector3(50f, 0, -45f);
    }

    private Tile[,] InitializeTiles()
    {
        Tile[,] tiles = new Tile[SIZE, SIZE];
        float halfSize = SIZE / 2f;
        float offset = 0.5f;
        for (int x = 0; x < SIZE ; x++)
        {
            for (int y = 0; y < SIZE; y++)
            {
                Tile tile = new Tile(x - halfSize + offset, y - halfSize + offset, this);
                BoardObject.Create<Tree>(tile);
                tiles[x, y] = tile;

            }
        }
        return tiles;
    }
}
