using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Coded by Charlie
public class MiniGameManager : MonoBehaviour {

	[SerializeField] public GameObject[] waypoints;
	private GameObject bugPrefab;
	public Controller control;

	[SerializeField] private List<GameObject> recipeObjects = new List<GameObject>();
	private int currentIndex;

	// Use this for initialization
	void Start () {
		currentIndex = 0;
		GameObject bug = Instantiate (Resources.Load("Bug")) as GameObject;
		bug.transform.position = waypoints [0].transform.position;

		waypoints = GameObject.FindGameObjectsWithTag ("Waypoint");

		/*GameObject scoreObject = GameObject.Find ("Score");
		GUIText scoreGT = scoreObject.GetComponent<GUIText> ();
		int score = int.Parse (scoreGT.text);
		scoreGT.text = score.ToString();*/
	}

	// Update is called once per frame
	void Update () {

	}
		
	public void NextIngredient (GameObject collidedWith) {
		Debug.Log(collidedWith.tag);
		GameObject nextInRecipe = (GameObject) recipeObjects [currentIndex + 1];
		if (collidedWith.CompareTag(nextInRecipe.tag)){
			if (currentIndex == recipeObjects.Count - 2) {
				Finish ();
			} else{
				GameObject currentIngedient = (GameObject) recipeObjects [currentIndex];
				currentIngedient.GetComponent<PlateCheck> ().enabled = false;
				currentIndex++;
				Debug.Log ("new index = " + currentIndex);
			}
		}
	}
		
	void Finish() {
		control.EndScene ();
		Debug.Log ("Finishing");
	}
}