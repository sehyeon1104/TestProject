using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refPractice : MonoBehaviour
{

    string name = "김세현";
    int age = 18;
    int MainValue = 7;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        sum(1, 2, 3, 4, 5, 6, 7, 7);
        PrintData(age:age,name:name);
    }
    void Update()
    {
       
    }
    int sum(params int[] num)
    {
        
        int sum = 0;    
        foreach(var num2 in num)
        {
            sum += num2;
        }
        return sum;
    }
    void PrintData(string name, int age)
    {
        print($"{name}은 {age}살 입니다");
    }
}
