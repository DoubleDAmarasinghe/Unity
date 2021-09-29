using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerpaddle;
    public Paddle computerpaddle;
    public Text computerscoretext;
    public Text playerscoretext;
    private int _playerscore;
    private int _computerscore;

    public void PlayerScore()
    {
        _playerscore++;
        this.playerscoretext.text = _playerscore.ToString();
        ResetRound();
    }

    public void ComputerScore()
    {
        _computerscore++;
        this.computerscoretext.text = _computerscore.ToString();  
        ResetRound();
        
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerpaddle.ResetPosition();
        this.computerpaddle.ResetPosition();
    }

}
