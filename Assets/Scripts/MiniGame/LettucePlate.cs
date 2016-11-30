using UnityEngine;
using System.Collections;

// Coded by Charlie
public class LettucePlate : PlateState {

	private MiniGameManager gameManager;

	public LettucePlate(MiniGameManager gameManager){
		this.gameManager = gameManager;
	}

	public void FoodCollided (GameObject collidedWith) {
		if (collidedWith.CompareTag("Bread")){
			GameObject plateObject = GameObject.FindGameObjectWithTag ("Lettuce");
			plateObject.GetComponent<PlateCheck> ().enabled = false;
			Debug.Log ("lettuce state to 'Complete' panel");
			//TODO gameManager.FinishMiniGame ();
		}
	}

}