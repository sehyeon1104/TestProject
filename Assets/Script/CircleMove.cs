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
    private void Awake()
    {
        tran= GetComponent<Transform>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            degree += speed;
             radian = degree * Mathf.PI / 180; //라디안값

            retVector.x += 1 * Mathf.Cos(radian);
            retVector.y += 1 * Mathf.Sin(radian);

            tran.position = retVector;
        }
    }
}
