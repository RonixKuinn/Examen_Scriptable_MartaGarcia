using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rBody;
    private float speed = 5;
    private float horizontalInput;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(horizontalInput * speed, rBody.velocity.y);
    }
}































/*
Inventory Manager

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager instance;
   public ScriptableItem[] weapons;
   public Text[] weaponsNames;
   public Image[] weaponsSprites;

   public InventorySlot[] weaponSlots;

   void Awake()
   {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
   }

    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i ++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;

                weaponSlots[i].slotItem = item;
                weaponSlots[i].slotNumber = i;

                return;
            }
        }
    }
}
-----------------------
Item

public class Item : MonoBehaviour
{
   public ScriptableItem itemInfo;
   private SpriteRenderer spriteRendered;

   void Awake()
   {
    spriteRendered = GetComponent<SpriteRenderer>();
   }

    void Start()
    {
        spriteRendered.sprite = itemInfo.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
----------------------------
Scriptable Item

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]

public class ScriptableItem : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int itemPrice;
    public Sprite itemSprite;
}
*/