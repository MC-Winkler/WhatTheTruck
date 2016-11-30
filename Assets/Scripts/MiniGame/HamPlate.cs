using UnityEngine;
using System.Collections;

// Coded by Charlie
public class HamPlate : PlateState {

	private MiniGameManager gameManager;

	public HamPlate(MiniGameManager gameManager){
		this.gameManager = gameManager;
	}

	public void FoodCollided (GameObject collidedWith) {
		if (collidedWith.CompareTag("Cheese")){
			gameManager.SetPlateState (new CheesePlate(gameManager));
			GameObject plateObject = GameObject.FindGameObjectWithTag ("Ham");
			plateObject.GetComponent<PlateCheck> ().enabled = false;
			Debug.Log ("ham state to cheese state");
		}
	}

}