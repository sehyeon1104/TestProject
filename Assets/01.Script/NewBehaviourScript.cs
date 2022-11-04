using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField]
    float a;
    Renderer rd;
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rd.material.SetFloat("_Float", a);
    }
}
