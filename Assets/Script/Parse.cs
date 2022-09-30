using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Parse : MonoBehaviour
{
    string ss = "90";
    int a = 0;
    bool us = true;
    private void Start()
    {
        a = Convert.ToInt32(ss);
    }
    private void Update()
    {
        int aa = a switch
        {
            10 => 1,
            30 =>3,
            _  when us==true=> 2, 
            _=>4
        };
        print(aa);
       
    }
}
