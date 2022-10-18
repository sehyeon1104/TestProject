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
        print($"초기값 : {MainValue}");
        print($"그냥 a값 : {a}");
    }
    public ref int ReturnValue()
    {
        return ref MainValue;
    }
}
