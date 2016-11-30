using UnityEngine;
using System.Collections;

public class Chef : MonoBehaviour {

	private GameObject whereToMove;
	[SerializeField] private GameManager gameManager;
	[SerializeField] private GameObject grillPosition;
	[SerializeField] private GameObject fridgePosition;
	[SerializeField] private GameObject counterPosition;

	private float velocity = 5f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position,
			whereToMove.transform.position, velocity * Time.deltaTime);
		if (transform.position == grillPosition.transform.position){
		}

		if (transform.position == fridgePosition.transform.position) {
			
		}

		if (transform.position == counterPosition.transform.position) {
		}
	}

	public void MoveToGrill() {
		whereToMove = grillPosition;
	}

	public void MoveToFridge() {
		whereToMove = fridgePosition;
	}

	public void MoveToCounter() {
		whereToMove = counterPosition;
	}
}
