using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NxtLvL : MonoBehaviour
{

   public void PlayGame()
   {
    SceneManager.LoadScene("cubethon2");
   }
   public void Replay()
   {
    SceneManager.LoadScene("Cubethon");
   }
}
