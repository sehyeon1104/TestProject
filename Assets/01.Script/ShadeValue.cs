using UnityEngine;

public class ShadeValue : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField]
    float changeValue;
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        renderer.material.SetFloat("_Float", changeValue);
    }
}
