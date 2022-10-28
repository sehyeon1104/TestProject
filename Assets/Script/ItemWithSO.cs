using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWithSO : MonoBehaviour
{
    [SerializeField]
    ItemSO itemSO;

    private void OnTriggerEnter(Collider other)
    {
        PlayerControllerwithSO itemManager =
            other.GetComponent<PlayerControllerwithSO>();

        itemManager?.SetColor(itemSO);
        Destroy(gameObject);
    }
}
