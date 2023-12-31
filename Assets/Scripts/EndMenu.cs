using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndMenu : MonoBehaviour
{
    public TextMeshProUGUI finalText;

    public void Start(){
        finalText.text = $"Score \n{GameManager.Score.ToString()}";
    }

    public void RetryGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit(){
        Application.Quit();
    }
}
