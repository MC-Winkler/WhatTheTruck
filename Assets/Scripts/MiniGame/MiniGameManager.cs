using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Coded by Charlie
public class MiniGameManager : MonoBehaviour {

	[SerializeField] private List<GameObject> recipeObjects = new List<GameObject>();
	private int currentIndex;

	// Use this for initialization
	void Start () {
		currentIndex = 0;
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
		Debug.Log ("Finishing");
	}
}