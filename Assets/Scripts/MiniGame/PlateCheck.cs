using UnityEngine;
using System.Collections;

public class PlateCheck : MonoBehaviour {

	[SerializeField] private MiniGameManager gameManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter (Collision coll) {
		GameObject collidedWith = coll.gameObject;
		Debug.Log ("collidedWith = " + collidedWith.tag);
		gameManager.NextIngredient (collidedWith);
		if (collidedWith.CompareTag ("Trash")) {
			Destroy (this);
		}
	}
}
