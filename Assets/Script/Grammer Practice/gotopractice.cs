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
        print("a�� 10�Դϴ�");

    ex_daa:
        print("a�� 10�� �ƴմϴ�");


    }
}
