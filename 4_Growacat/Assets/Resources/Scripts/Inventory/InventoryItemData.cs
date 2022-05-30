using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Cat Data")]
public class InventoryItemData : ScriptableObject
{
    public string id;
    public string displayName;
    [TextArea(4, 4)]
    public string description;
    public Sprite icon;
    public int MaxStackSize;
    public GameObject prefab;
}
