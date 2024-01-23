using UnityEngine;

public class Tile
{
    private Board _board;
    private GameObject _tileGameObject;
    private BoardObject _content;

    public Tile(float x, float y, Board board)
    {
        _tileGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        _tileGameObject.transform.parent = board.transform;
        _tileGameObject.transform.localPosition = new Vector2(x, y);
        _tileGameObject.transform.localScale = Vector3.one * 0.9f;
        
        _board = board;
    }

    public void SetContent(BoardObject content)
    {
        content.transform.SetParent(_tileGameObject.transform);
        content.transform.localPosition = Vector3.forward;
        _content = content;
    }

    public BoardObject GetContent()
    {
        return _content;
    }
}