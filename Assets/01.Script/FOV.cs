using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FOV : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    [Tooltip("�þ߰�")]
    float angle = 90f;
    
    
    void Start()
    {

    }
    void Update()
    {
    Vector3 dot =Vector3.Dot(transform.forward)
    }
}
