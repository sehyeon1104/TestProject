using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FOV : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    [Tooltip("시야각")]
    float angle = 90f;
    Vector3 LookTarget=new Vector3(0,0,0);
    void Start()
    {

    }
    void Update()
    {
     LookTarget = (target.position - transform.position).normalized;
        if(Vector3.Angle(transform.forward,LookTarget)<angle/2)
        {
            print("적 발견");
        }
    }
}
