using UnityEngine;
using System.Collections;

// Coded by Charlie
public class Bug : MonoBehaviour {

	private float velocity = 10f;
	private int index = 1;
	private int score;
	private MiniGameManager gameManager;

	void OnCollisionEnter (Collision coll) {
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.CompareTag ("Player")) {
			Destroy (this);
			GameObject scoreObject = GameObject.Find ("Score");
			GUIText scoreGT = scoreObject.GetComponent<GUIText> ();
			int score = int.Parse (scoreGT.text);
			score += 100;
			scoreGT.text = score.ToString();
		}
	}

	// Use this for initialization
	void Start () {
		gameManager = (MiniGameManager) FindObjectOfType (typeof(MiniGameManager));
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("the array: " + gameManager.waypoints);
		while (GameObject.FindGameObjectWithTag("Bug") != null) {
			transform.position = Vector3.MoveTowards(transform.position,
				gameManager.waypoints[index].transform.position, velocity * Time.deltaTime);
			if (index == gameManager.waypoints.Length - 1) {
				index = 0;
			} else {
				index++;
			}
		}
	}
}
