using System;
using UnityEngine;

public class interactble : MonoBehaviour

{
   public void OnTriggerEnter2D(Collider2D other)
   {
      Destroy(gameObject);
   }
}
