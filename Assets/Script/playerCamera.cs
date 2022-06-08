using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour
{
    public Transform _target;
    public float detailX = 5f;
    public float detailY = 5f;
    public float rotateX;
    public float rotateY;
    void Start()
    {
      
    }
     
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
            
        rotateX += mouseX * detailX;
        rotateY += mouseY * detailY;

        transform.eulerAngles = new Vector3(-rotateY,rotateX, 0);
        transform.position = _target.position;
        _target.eulerAngles = new Vector3(0, rotateX, 0);
    }
  
}

public abstract class Item:MonoBehaviour

{
    public abstract void Die();
    public abstract void OnRay();

}

public class Box : Item
{
    public override void Die()
    {
        Destroy(gameObject);
    }
    public override void OnRay()
    {
        Debug.Log("{F}눌러서 얻기");
    }
}
public class Sphere : Item
{
    public override void Die()
    {
        Destroy(gameObject);
    }
    public override void OnRay()
    {
        Debug.Log("aaaa");
    }
}