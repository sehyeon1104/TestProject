using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item 
{
    public int item_id = -1;
    public string item_name;
    public ItemAbility[] ability;

    // Update is called once per frame
    void Update()
    {
        item_id = -1;
        item_name = "";
    }
}
