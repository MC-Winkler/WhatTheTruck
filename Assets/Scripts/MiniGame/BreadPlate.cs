using UnityEngine;
using System.Collections;

// Coded by Charlie
public class BreadPlate : PlateState {

	private MiniGameManager gameManager;

	public BreadPlate(MiniGameManager gameManager){
		this.gameManager = gameManager;
	}

	public void FoodCollided (GameObject collidedWith) {
		
		if (collidedWith.CompareTag("Ham")){
			gameManager.SetPlateState (new HamPlate(gameManager));
			GameObject plateObject = GameObject.FindGameObjectWithTag ("Bread");
			plateObject.GetComponent<PlateCheck> ().enabled = false;
			Debug.Log ("bread state to ham state");
		}
	}

}