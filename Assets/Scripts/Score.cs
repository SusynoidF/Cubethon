using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
     
    public float scoredown;
    public Text scoreText;
    public Transform player;
    void Update()
    {
       
        float score = player.position.z + scoredown;
        scoreText.text = score.ToString("0");
    }
}
