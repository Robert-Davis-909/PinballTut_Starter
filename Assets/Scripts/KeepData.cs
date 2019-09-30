using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public Text showScore;
    public Text HighScore;
  
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void ShowScore()
    {
        showScore.text = DestroyBall.aScore.ToString();
        Debug.Log(DestroyBall.HighScore);
    }

    public void ShowHighScore()
    {
        HighScore.text = DestroyBall.HighScore.ToString();
        Debug.Log(DestroyBall.HighScore);
    }

}