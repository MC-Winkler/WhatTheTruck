using UnityEngine;
using System.Collections;

// Coded by Charlie
public class CheesePlate : PlateState {

	private MiniGameManager gameManager;

	public CheesePlate(MiniGameManager gameManager){
		this.gameManager = gameManager;
	}

	public void FoodCollided (GameObject collidedWith) {
		if (collidedWith.CompareTag("Lettuce")){
			gameManager.SetPlateState (new LettucePlate(gameManager));
			GameObject plateObject = GameObject.FindGameObjectWithTag ("Cheese");
			plateObject.GetComponent<PlateCheck> ().enabled = false;
			Debug.Log ("cheese state to lettuce state");
		}
	}

}