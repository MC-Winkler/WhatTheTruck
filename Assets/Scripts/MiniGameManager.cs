using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Coded by Charlie
public class MiniGameManager : MonoBehaviour {

	[SerializeField] public GameObject[] waypoints;
	[SerializeField] private Text instructionText;
	private ArrayList instructions;
	private string[] currentLevelInstructions;
	private int currentSceneIndex;
	public Controller control;

	[SerializeField] private List<GameObject> recipeObjects = new List<GameObject>();
	private int currentIndex;

	// Use this for initialization
	void Start () {
		currentIndex = 0;
		currentSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;

		GenerateInstructions();
		currentLevelInstructions = (string[]) instructions[currentSceneIndex];
		instructionText.text = "Current task:\n" + currentLevelInstructions[0];

		//GameObject bug = Instantiate (Resources.Load("Bug")) as GameObject;
		//bug.transform.position = waypoints [0].transform.position;

		//waypoints = GameObject.FindGameObjectsWithTag ("Waypoint");

		/*GameObject scoreObject = GameObject.Find ("Score");
		GUIText scoreGT = scoreObject.GetComponent<GUIText> ();
		int score = int.Parse (scoreGT.text);
		scoreGT.text = score.ToString();*/
	}

	// Update is called once per frame
	void Update () {

	}
		
	public void NextIngredient (GameObject collidedWith) {
		Debug.Log("CollidedWith tag = " + collidedWith.tag);
		GameObject nextInRecipe = (GameObject) recipeObjects [currentIndex + 1];
		Debug.Log("Next tag in recipe = " + nextInRecipe.tag);
		if (collidedWith.CompareTag(nextInRecipe.tag)){
			if (currentIndex == recipeObjects.Count - 2) {
				Finish ();
			} else{
				GameObject currentIngedient = (GameObject) recipeObjects [currentIndex];
				currentIngedient.GetComponent<PlateCheck> ().enabled = false;
				currentIndex++;	
				instructionText.text = "Current task:\n" + currentLevelInstructions[currentIndex];
				Debug.Log ("new index = " + currentIndex);
			}
		}
	}
		
	void Finish() {
		control.EndScene ();
		Debug.Log ("Finishing");
	}

	private void GenerateInstructions() {
		instructions = new ArrayList();

		string[] level1 = {"Place the apple on the plate"};
		string[] level2 = {"Place a piece of bread on the plate",
			"Place the hame on the bread", "Place the cheese on the ham",
			"Place the lettuce on the cheese", "Finish the sandwich with the other piece of bread"};
		string[] level3 = {"Place the bottom bun on the plate", 
			"Cook the hamburger on the grill and then put it on the bun",
			"Add the lettuce to the burger", "Add the tomato to the burger",
			"Finish the burger by adding the top bun"};
		string[] level4 = {"Put both pieces of bread in the toaster. The toaster will toast them. Once they're toasted, put them on the plate"};

		instructions.Add(level1);
		instructions.Add(level2);
		instructions.Add(level3);
		instructions.Add(level4);
	}
}