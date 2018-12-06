using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour{

	public TextMeshProUGUI scoreDisplay;
	private int currentScore;

	void Start()
	{
		currentScore = 0;
		UpdateUI();
	}

	public void AddToScore(int pointsGained)
	{
		currentScore += pointsGained;

		UpdateUI();
	}

	void UpdateUI()
	{
		scoreDisplay.text = "Score: " + currentScore;
	}

}
