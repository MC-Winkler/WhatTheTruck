using UnityEngine;
using System.Collections;

// Coded by Charlie
public class MiniGameManager : MonoBehaviour {

	public PlateState currentPlateState;

	// Use this for initialization
	void Start () {
		currentPlateState = new EmptyPlate (this);
	}

	// Update is called once per frame
	void Update () {

	}

	// State changing method to be called by each state
	public void SetPlateState (PlateState plateState) {
		this.currentPlateState = plateState;
	}

	public void NextIngredient (GameObject collidedWith) {
		Debug.Log ("collidedWith in the manager = " + collidedWith);
		currentPlateState.FoodCollided (collidedWith);
	}
}