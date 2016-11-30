using UnityEngine;
using System.Collections;

public class EmptyHands : ChefState {

	private GameManager gameManager;

	public EmptyHands(GameManager gameManager){
		this.gameManager = gameManager;
	}

	public void InteractWithGrill(){
		if (gameManager.currentGrillState is EmptyGrill){
			Debug.Log("You need to get some food to put on the grill");
		} else if (gameManager.currentGrillState is FullGrillFoodCooking){
			Debug.Log("You need to wait for the food to finish");
		} else if (gameManager.currentGrillState is FullGrillFoodDone){
			Debug.Log("You picked up the cooked food");
			gameManager.currentChefState = gameManager.holdingFood;
			gameManager.currentGrillState = gameManager.emptyGrill;
		}
	}

	public void InteractWithFridge(){
		Debug.Log("You grab some ingredients from the fridge");
		gameManager.currentChefState = gameManager.holdingIngredients;
	}

	public void InteractWithCounter(){
		Debug.Log("You need to pick up some food to deliver");
	}
}
