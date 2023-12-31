using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static int score;
    private float timer;
    private Spawner spScrComp;
    private float delayBetweenSpawns = 0.5f;

    public GameObject spawnerObj;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public static int Score {
        get{ return score; }
    }
    
    void Start()
    {
        spScrComp = spawnerObj.GetComponent<Spawner>();
        score = 0;
        timer = 60;
        StartCoroutine(StartSpawnCirces());
        StartCoroutine(CountdownTimeAndFinishGame());
    }

    void Update(){
        scoreText.text = $"Score: {score.ToString()}";
    }

    private IEnumerator StartSpawnCirces(){
        while(true){
            spScrComp.SpawnCircle();
            yield return new WaitForSeconds(delayBetweenSpawns);
        }
    }

    public void AddScore(int points){
        score+=points;
    }

    private IEnumerator CountdownTimeAndFinishGame(){
        while(timer>0){
            timerText.text = $"Timer: {timer}";

            yield return new WaitForSeconds(1);

            timer--;
        }
        LoadEndMenu();
    }

    private void LoadEndMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
