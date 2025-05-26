using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   private SpriteRenderer spriteRendered;

   void Awake()
   {
        spriteRendered = GetComponent<SpriteRenderer>();
   }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    } 
}
