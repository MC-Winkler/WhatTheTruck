using UnityEngine;
using System.Collections;

public class HoldingIngredients : ChefState {

	private GameManager gameManager;

	public HoldingIngredients(GameManager gameManager){
		this.gameManager = gameManager;
	}

	public void InteractWithGrill(){
		if (gameManager.currentGrillState is EmptyGrill){
			Debug.Log("You started cooking some food");
			gameManager.currentGrillState = gameManager.fullGrillFoodDone;
			gameManager.currentChefState = gameManager.emptyHands;
		} else if (gameManager.currentGrillState is FullGrillFoodCooking){
			Debug.Log("The grill already has food on it");
		} else if (gameManager.currentGrillState is FullGrillFoodDone){
			Debug.Log("You picked up the cooked food");
			gameManager.currentGrillState = gameManager.emptyGrill;
			gameManager.currentChefState = gameManager.holdingFood;
		}
	}

	public void InteractWithFridge(){
		Debug.Log("You already have ingredients in your hands");
	}

	public void InteractWithCounter(){
		Debug.Log("You need to pick up some food to deliver");
	}


}
