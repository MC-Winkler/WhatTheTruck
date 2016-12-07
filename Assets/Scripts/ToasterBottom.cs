using UnityEngine;
using System.Collections;

public class ToasterBottom : MonoBehaviour {

	private ArrayList theBreads;
	private float velocity = 0;
	private float deltaY = 0;
	private bool alreadyToasted = false;
	[SerializeField] private float springSpeed = 6f;
	[SerializeField] private float heightLimit = 1.5f;
	static int numToasted = 0;

	// Use this for initialization
	void Start () {
		theBreads = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (deltaY < heightLimit) {
			pos.y += velocity * Time.deltaTime;
			transform.position = pos;
			deltaY += velocity * Time.deltaTime;
		}

		if (numToasted == 2){
			StartCoroutine(LaunchToast());
		}	
	}

	void OnCollisionEnter(Collision coll) {
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.CompareTag ("Bread")) {
			StartCoroutine(ToastBread(collidedWith));
		} else if (collidedWith.CompareTag("Toast") && !alreadyToasted){
			alreadyToasted = true;
			numToasted ++;
			Debug.Log ("numToasted = " + numToasted);

		}
	}

	private IEnumerator ToastBread(GameObject bread) {
		Debug.Log("Toasting bread");
		yield return new WaitForSeconds(3);
		GameObject toastObject = Instantiate(Resources.Load("Toast")) as GameObject;
		toastObject.transform.position = bread.transform.position;
		toastObject.transform.rotation = bread.transform.rotation;
		Destroy (bread);
		
	}

	private IEnumerator LaunchToast() {
		yield return new WaitForSeconds(1);
		velocity += springSpeed;
	}
}
