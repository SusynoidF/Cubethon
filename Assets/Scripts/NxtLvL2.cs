using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NxtLvL2 : MonoBehaviour
{

  public void QuitGame()
   {
    Application.Quit();
   }
   public void Replay()
   {
    SceneManager.LoadScene("cubethon3");
   }
}
