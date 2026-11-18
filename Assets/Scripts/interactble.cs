using System;
using TMPro;
using UnityEngine;

public class interactble : MonoBehaviour

{
   [SerializeField] private GameObject particles;
   public void OnTriggerEnter2D(Collider2D other)
   {
      if (particles != null)
      {
         particles.SetActive(true);
      }

      Destroy(gameObject);
   }
}
