using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : MonoBehaviour
{
    RaycastHit hit;
    public float moveSpeed = 10f;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Attack();
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            moveDirection = new Vector3(h, 0, v);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
        
        controller.SimpleMove(moveDirection);
    }
    void Attack()
    {
            
        Debug.DrawRay(transform.position, transform.forward * 15, Color.red);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Physics.Raycast(transform.position, transform.forward,out hit, 15))
            {
                hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                Item a = hit.transform.GetComponent<Item>();
                a.OnRay();
            }
        }
    }
}
