using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerScore;
    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPositions;

    public static GameManager instance;
    void Start()
    {
        instance = this;
        
        SetBall(BallColor.Red,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetBall(BallColor col, int i)
    {
        GameObject obj = Instantiate(ballPrefab, ballPositions[i].transform.position, Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }
}
