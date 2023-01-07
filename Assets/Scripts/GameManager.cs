using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    
    public float gameWidth = 30.6f;
    [HideInInspector]
    public int score {get;private set;} = 0;

    public GameObject player;
    [HideInInspector]
    public bool isGameActive {get; private set;} = true;
    public float restartDelay = 5.0f;

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

    // public void StartGame(){
    //     if(isGameActive){
    //         return;
    //     }
    //     isGameActive = true;
    //     score = 0;
    //     player.transform.position = new Vector3(0,-9,-1);
    //     Debug.Log("StartGame");
    // }

    public void GameOver(){
        if(!isGameActive){
            return;
        }
        // if(player != null){
            // Destroy(player);
        isGameActive = false;
        gameOverPanel.SetActive(true);
        Debug.Log("GameOver");
        // Invoke("RestartGame",restartDelay);
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
