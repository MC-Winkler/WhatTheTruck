using UnityEngine;
using System.Collections;

public class UncookedPatty : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll) {
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.CompareTag ("Stove")) {
			StartCoroutine(Cook());
		}
	}

	private IEnumerator Cook() {
		yield return new WaitForSeconds(3);
		GameObject cookedPatty = Instantiate(Resources.Load("CookedPatty")) as GameObject;
		cookedPatty.transform.position = transform.position;
		cookedPatty.transform.rotation = transform.rotation;
		Destroy (gameObject);
	}
}
