using UnityEngine;
using System.Collections;

public class PlateCheck : MonoBehaviour {

	private MiniGameManager gameManager;

	// Use this for initialization
	void Start () {
		GameObject miniGameManagerObject = GameObject.FindWithTag("MiniGameManager");
		gameManager = (MiniGameManager) miniGameManagerObject.GetComponent(typeof(MiniGameManager));
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter (Collision coll) {
		GameObject collidedWith = coll.gameObject;
		//Debug.Log ("collidedWith = " + collidedWith.tag);
//		if (collidedWith.CompareTag ("Trash")) {
//			Destroy (gameObject);
//		} else {
		Debug.Log ("calling gameManager.nextingred");
		gameManager.NextIngredient (collidedWith);
	//}
	}
}
