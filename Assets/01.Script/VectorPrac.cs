using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPrac : MonoBehaviour
{
    float speed = 10f;
    float dot;
    Transform cubeTrans;
    private void Awake()
    {
        cubeTrans = GetComponent<Transform>();
    }
    void Update()
    {
        cubeTrans.eulerAngles =new Vector3(0, Time.time*speed, 0);
       float dot = Vector3.Dot(Vector3.forward, cubeTrans.forward);
        print(dot);
    }
}
