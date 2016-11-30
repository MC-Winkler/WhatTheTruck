using UnityEngine;
using System.Collections;

public class FridgeScript : MonoBehaviour {

	[SerializeField] private GameManager gameManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		gameManager.ClickedOnFridge();
	}
}
