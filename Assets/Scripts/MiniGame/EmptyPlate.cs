using UnityEngine;
using System.Collections;

// Coded by Charlie
public class EmptyPlate : PlateState {

	private MiniGameManager gameManager;

	public EmptyPlate(MiniGameManager gameManager){
		this.gameManager = gameManager;
	}

	public void FoodCollided (GameObject collidedWith) {
		if (collidedWith.CompareTag("Bread")){
			gameManager.SetPlateState (new BreadPlate(gameManager));
			GameObject plateObject = GameObject.FindGameObjectWithTag ("Plate");
			plateObject.GetComponent<PlateCheck> ().enabled = false;
			Debug.Log ("empty state to bread state");
		}
	}

}
