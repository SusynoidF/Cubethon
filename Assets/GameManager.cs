using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WinlevelUI;
    public float restartdelay = 1f;
    bool gameEnded = false;
   public void GameOver()
   { 
    if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAme Over");
            Invoke("Restart", restartdelay );
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("Cubethon");
    }
    public void Win()
    {
        WinlevelUI.SetActive(true);
    }
}
