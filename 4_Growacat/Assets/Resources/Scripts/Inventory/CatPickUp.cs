using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CatPickUp : MonoBehaviour
{
    public InventoryItemData itemData;
    [SerializeField] GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var inventory = player.transform.GetComponent<InventoryHolder>();
            if (!inventory)
                return;
            if (inventory.InventorySystem.AddToInventory(itemData, 1))
            {
                Destroy(this.gameObject);
            }
        }
    }
}