using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DotweenPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(Vector3.up, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
