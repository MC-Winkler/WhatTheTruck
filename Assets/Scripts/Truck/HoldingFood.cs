using UnityEngine;
using System.Collections;

public class HoldingFood : ChefState {

	private GameManager gameManager;

	public HoldingFood(GameManager gameManager){
		this.gameManager = gameManager;
	}

	public void InteractWithGrill(){
		Debug.Log("You need to deliver the food you're currently holding!");
	}

	public void InteractWithFridge(){
		Debug.Log("You need to deliver the food you're currently holding!");
	}

	public void InteractWithCounter(){
		Debug.Log("You delivered the food");
		gameManager.currentChefState = gameManager.emptyHands;
	}
}
