using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPrac : MonoBehaviour
{
    float speed = 10f;
    float dot,angle;
    
    Transform cubeTrans;
    private void Awake()
    {
        cubeTrans = GetComponent<Transform>();
    }
    void Update()
    {
        cubeTrans.eulerAngles =new Vector3(0, Time.time*speed, 0);
        dot = Vector3.Dot(Vector3.forward, cubeTrans.forward);
        angle = Mathf.Acos(dot)*Mathf.Rad2Deg;
        print($"내적 값 : {angle} 회전 : {cubeTrans.localEulerAngles}");

    }
}
