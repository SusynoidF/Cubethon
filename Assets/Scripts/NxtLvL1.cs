using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NxtLvL1 : MonoBehaviour
{

   public void PlayGame()
   {
    SceneManager.LoadScene("cubethon3");
   }
   public void Replay()
   {
    SceneManager.LoadScene("cubethon2");
   }
}
