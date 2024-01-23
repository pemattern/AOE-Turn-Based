using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        transform.LookAt(Vector3.zero);
    }
}
