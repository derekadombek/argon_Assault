using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] int scorePerHit = 12;
    Text scoreText;
    // Start is called before the first frame update
    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }
    public void ScoreHit()
    {
        score += scorePerHit;
        scoreText.text = score.ToString();
    }
}
