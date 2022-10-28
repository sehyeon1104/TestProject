using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Transform target;
    public float height = 5.0f;
    public float distance = 10f;
    public float angle = 45;
    public float lookAtHeight = 1f;
    public float smoothSpeed = 0.5f;

    Vector3 refVelocity;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        HandleCamera();
    }
    void HandleCamera()
    {
        if (!target)
            return;
        Vector3 worldPosition = (Vector3.forward * -distance) + (Vector3.up * height);
        Vector3 rotatedVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPosition;

        Vector3 flatTargetPosition = target.position;
        flatTargetPosition.y += lookAtHeight;

        Vector3 finalPosition = flatTargetPosition + rotatedVector;

        transform.position = Vector3.SmoothDamp(transform.position, finalPosition, ref refVelocity, smoothSpeed);

        transform.LookAt(flatTargetPosition);
    }
}
