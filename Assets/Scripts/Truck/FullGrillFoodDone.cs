using UnityEngine;
using System.Collections;

public class FullGrillFoodDone : GrillState {

	private GameManager gameManager;

	public FullGrillFoodDone(GameManager gameManager){
		this.gameManager = gameManager;
	}

	public void GrillClicked () {
		Debug.Log ("You Removed the Food");
		gameManager.SetGrillState (gameManager.emptyGrill);
	}
}
