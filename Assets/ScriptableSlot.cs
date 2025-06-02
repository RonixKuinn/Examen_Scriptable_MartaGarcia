using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]
public class ScriptableSlot : ScriptableObject
{
    public string itemName;
    public int itemPrice;
    public Sprite itemSprite;
}
