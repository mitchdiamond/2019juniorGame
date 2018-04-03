﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Enemy")]
public class SO_Enemy : ScriptableObject {

	public string EnemyType= "default";												//String used to identify and compare enemy's within other scripts
	[Tooltip("Prefab of this enemy")]
	public GameObject enemyPrefab;													//Enemy Prefab used to spawn enemies
	[Tooltip("How dangerous is the enemy")]
	public int dangerRating;

	public GameObject CreateEnemyInstance(Vector3 Pos, bool toBeActive){			//creates enemy prefab at a postion and returns the gameobject, called from enemy spawner
		GameObject enemy = Instantiate (enemyPrefab, Pos, Quaternion.identity);		//Instanciates the enemy prefab into memory at the given postion
		enemy.SetActive(toBeActive);												//Disables or enebles the enemy depending on method input
		return enemy;																//returns the enemy game object
	}
}
