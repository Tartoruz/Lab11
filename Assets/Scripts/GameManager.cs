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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
