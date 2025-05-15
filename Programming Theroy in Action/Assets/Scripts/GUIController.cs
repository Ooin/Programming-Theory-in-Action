using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoringLabel;
    private int currentScore;

    private void Start()
    {
        currentScore = 0;
        UpdateScoreUI();
    }

    public void Score(int i)
    {
        currentScore += i;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        ScoringLabel.text = "Score: " + currentScore.ToString();
    }
}
