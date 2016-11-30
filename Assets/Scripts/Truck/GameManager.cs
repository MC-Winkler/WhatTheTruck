using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GrillState emptyGrill;
	public GrillState fullGrillFoodCooking;
	public GrillState fullGrillFoodDone;
	public GrillState currentGrillState;

	public ChefState emptyHands;
	public ChefState holdingIngredients;
	public ChefState holdingFood;
	public ChefState currentChefState;

	[SerializeField] private Chef chef;

	// Use this for initialization
	void Start () {
		emptyGrill = new EmptyGrill (this);
		fullGrillFoodCooking = new FullGrillFoodCooking (this);
		fullGrillFoodDone = new FullGrillFoodDone (this);
		currentGrillState = emptyGrill;

		emptyHands = new EmptyHands (this);
		holdingIngredients = new HoldingIngredients (this);
		holdingFood = new HoldingFood (this);
		currentChefState = emptyHands;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetGrillState (GrillState grillState) {
		this.currentGrillState = grillState;
	}

	public void SetChefState (ChefState chefState) {
		this.currentChefState = chefState;
	}

	public void ClickedOnGrill() {
		chef.MoveToGrill ();
		currentChefState.InteractWithGrill ();
	}

	public void ClickedOnFridge() {
		chef.MoveToFridge ();
		currentChefState.InteractWithFridge ();
	}

	public void ClickedOnCounter() {
		chef.MoveToCounter ();
		currentChefState.InteractWithCounter();
	}

	public void SwitchScene() {
		SceneManager.LoadScene ("Truck");
	}

}
