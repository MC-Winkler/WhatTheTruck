using UnityEngine;
using System.Collections;

public class FullGrillFoodCooking : GrillState {

	private GameManager gameManger;

	public FullGrillFoodCooking(GameManager gameManager){
		this.gameManger = gameManger;
	}

	public void GrillClicked () {
		Debug.Log ("The Food isn't done yet!");
	}
		
}
