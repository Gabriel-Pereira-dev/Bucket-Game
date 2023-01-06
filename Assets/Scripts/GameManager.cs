using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    public TextMeshProUGUI scoreText;
    
    public float gameWidth = 30.6f;
    [HideInInspector]
    public int score {get; private set;} = 0;
    void Awake(){
        if(Instance != null && Instance != this){
            Destroy(this);
        }else{
            Instance = this;
        }
        
    }

    public void AddScore(int newScore)
    {
        score+= newScore;
        if(scoreText != null){
            scoreText.text = "Score\n"+ score;
        }
    }
}
