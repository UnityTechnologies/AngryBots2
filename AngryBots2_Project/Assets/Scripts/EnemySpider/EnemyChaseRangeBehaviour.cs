using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseRangeBehaviour : MonoBehaviour {

	public EnemyChaseMovement enemyChaseMovement;

	void OnTriggerEnter(Collider theCollider)
	{
		if(theCollider.CompareTag("Player"))
		{
			enemyChaseMovement.PlayerIsNowInRange();
		}
	}

	void OnTriggerExit(Collider theCollider)
	{
		if(theCollider.CompareTag("Player"))
		{
			enemyChaseMovement.PlayerIsNowOutOfRange();
		}
	}
}
