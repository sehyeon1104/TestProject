using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    public GameObject[] obj;
    float circleR;
    float deg;
    float objSpeed;

    void Update()
    {
        deg += Time.deltaTime * objSpeed;
        if (deg < 360)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                var rad = Mathf.Deg2Rad * (deg + (i * (360 / obj.Length)));
                var x = circleR * Mathf.Sin(rad);
                var y = circleR * Mathf.Cos(rad);
                obj[i].transform.position = transform.position + new Vector3(x, y);
                obj[i].transform.rotation = Quaternion.Euler(0, 0, (deg + (i * (360 / obj.Length))) * -1);
            }

        }
        else
        {
            deg = 0;
        }
    }
}
