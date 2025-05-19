using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoringLabel;
    private int _currentScore;

    private void Start()
    {
        _currentScore = 0;
        UpdateScoreUI();
    }

    public void Score(int i)
    {
        _currentScore += i;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        ScoringLabel.text = "Score: " + _currentScore.ToString();
    }
}
