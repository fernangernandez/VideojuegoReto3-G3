using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object the camera will follow
    public float smoothSpeed = 0.125f; // The smoothness of camera movement. Higher values make it smoother.
    public Vector3 offset; // The offset of the camera from the target

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

        }
    }
}
