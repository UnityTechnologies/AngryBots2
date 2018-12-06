using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	[Header("Health Settings")]
	public int totalHealth = 100;
	private int currentHealth;

	[Header("Points Settings")]
	public int pointToGive = 0;
	private ScoreManager scoreManager;

	[Header("Explosion Effect")]
	public GameObject explosionPrefab;


	void Start()
	{
		currentHealth = totalHealth;

		if(pointToGive != 0)
		{
			scoreManager = GameObject.Find("ScoreCanvas").GetComponent<ScoreManager>();
		}
	}

	public void RemoveHealth(int damageTaken)
	{
		currentHealth -= damageTaken;

		if(currentHealth <= 0)
		{
			RemoveEnemy();
		}
	}

	void RemoveEnemy()
	{
		if(explosionPrefab)
		{
			Instantiate(explosionPrefab, transform.position, transform.rotation);
		}

		if(scoreManager)
		{
			scoreManager.AddToScore(pointToGive);
		}

		Destroy(gameObject);
	}


}
