using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refPractice : MonoBehaviour
{
    
    int MainValue = 7;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        ref int refa = ref ReturnValue();

        a=ReturnValue();
            refa = 200;
       
    }
    void Update()
    {
        print($"�ʱⰪ : {MainValue}");
        print($"�׳� a�� : {a}");
    }
    public ref int ReturnValue()
    {
        return ref MainValue;
    }
}
