using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class house : MonoBehaviour
{
   public int screen;

   private void OnTriggerEnter(Collider other)
   {
       if(other.tag == "Player")
       {
           SceneManager.LoadScene(screen);
       }
   }
}