using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType:int
{
    Head,
    Body,
    LeftHand,
    RightHand,
    Default,
}

[CreateAssetMenu(fileName ="New Item",menuName ="Inventory Sysyem/Items/New Item")]
public class ItemObj : ScriptableObject
{
    // ��� Ÿ��
    public ItemType ItemType;
    // �κ��丮���� ��ġ������ ����,
    public bool flagStackable;

    public Sprite itemIcon;
    public GameObject objModelOPrefeb;
    public List<string> boneNameLists = new List<string>();

    public Item itemData = new();

    [TextArea(15, 20)]
    public string itemSummery;

    private void OnValidate()
    {
        boneNameLists.Clear();      
    }
}
