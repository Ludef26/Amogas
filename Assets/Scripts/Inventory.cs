using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory{
    
    public List<Item> itemList;

    public Inventory() {
        itemList = new List<Item>();

        Debug.Log("Inventory");
    }

    public void addItem(Item item) {
        itemList.Add(item);
    }
}


