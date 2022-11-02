using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
   Transform tran;
    Vector3 retVector;

    public float speed = 1;
    private float degree = 0;
    float radian = 0;
    private void Start()
    {
        print(retVector);
    }
    private void Awake()
    {
        tran= GetComponent<Transform>();
    }
    void Update()
    {

        retVector.x = Mathf.Cos(Time.time);
        retVector.y = Mathf.Sin(Time.time);
        transform.position = retVector;
    }
}
