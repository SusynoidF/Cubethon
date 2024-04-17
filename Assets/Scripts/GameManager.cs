using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WinlevelUI;
    public float restartdelay = 1f;
    public float replaydelay = 5f;
    bool gameEnded = false;
    bool gameWon = false;
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
        gameWon = true;
       Time.timeScale = 0;
    }
    public void Replay()
    {
        if (gameWon == true)
        {
            Invoke("Restart", replaydelay);
        }
    }
}
