using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Vector3 ballPos;

    private void Update()
    {
        
    }
    public void NewBall()
    {
        GameObject ball = Instantiate(ballPrefab, ballPos, Quaternion.identity);
    }
}
