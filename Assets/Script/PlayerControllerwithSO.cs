using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerwithSO : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    public void SetColor(ItemSO itemColor)
    {
        Color color = itemColor.color;
        player.GetComponent<Renderer>().material.color = color;

        print($"SetColor : {itemColor.itemColor}");
    }
}
