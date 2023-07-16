using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.15f;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;    
    }

}
