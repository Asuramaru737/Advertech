using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] circlePrefabs;

    private Vector3 leftUpperPosLimit = new Vector3(-2, 3, 0), 
                    rightLowerPosLimit = new Vector3(2, -4, 0);

    public void SpawnCircle(){
        var circle = circlePrefabs[Random.Range(0, circlePrefabs.Length)];
        var horizontalPos = Random.Range(leftUpperPosLimit.x, rightLowerPosLimit.x);
        var verticalPos = Random.Range(leftUpperPosLimit.y, rightLowerPosLimit.y);
        var spawnPos = new Vector3(horizontalPos, verticalPos, 0);
        
        Instantiate(circle, spawnPos, Quaternion.identity);
    }
}
