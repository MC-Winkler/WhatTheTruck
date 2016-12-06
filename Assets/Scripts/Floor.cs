using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public Controller control;

	void OnCollisionEnter(Collision coll){
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.tag == "Bread" || collidedWith.tag == "Ham" || collidedWith.tag == "Lettuce" || collidedWith.tag == "Cheese") {
			control.DroppedFood ();
		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
