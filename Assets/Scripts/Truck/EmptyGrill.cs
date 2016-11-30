using UnityEngine;
using System.Collections;

public class EmptyGrill : GrillState {

	private GameManager gameManager;

	public EmptyGrill(GameManager gameManager){
		this.gameManager = gameManager;
	}

	public void GrillClicked () {
		gameManager.SetGrillState (gameManager.fullGrillFoodCooking);
	}

}
