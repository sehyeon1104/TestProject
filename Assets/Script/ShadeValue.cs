using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadeValue : MonoBehaviour
{
    [SerializeField]
    Renderer rd;
    void Start()
    {
        rd.material.SetFloat("_Float", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
