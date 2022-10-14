using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refPractice : MonoBehaviour
{
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        transform.position= transform.localPosition;
    }
}
