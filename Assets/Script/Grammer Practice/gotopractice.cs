using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotopractice : MonoBehaviour
{
    int a = 9;

    private void Start()
    {
        if(a==10)
        {
            goto ex_dss;
        }
        goto ex_daa;
    ex_dss:
        print("a는 10입니다"); // a==10일때

    ex_daa:
        print("a는 10이 아닙니다"); // a!=10일때
    

    }
}
