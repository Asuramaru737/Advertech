using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    [SerializeField]
    private int points;
    public int Points {get{return points;}}
    [SerializeField]
    private float delayBeforeDestroy;
    private GameManager gm;
    private GameObject soundSrc;

    private void Awake(){
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        soundSrc = GameObject.Find("SoundSrc");
        Destroy(this.gameObject, delayBeforeDestroy);
    }

    void OnMouseDown(){
        gm.AddScore(points);
        soundSrc.GetComponent<AudioSource>().Play();
        Destroy(this.gameObject);
    }
}
