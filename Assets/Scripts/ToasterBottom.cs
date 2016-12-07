using UnityEngine;
using System.Collections;

public class ToasterBottom : MonoBehaviour {

	private ArrayList theBreads;
	private int numToasted = 0;

	// Use this for initialization
	void Start () {
		theBreads = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll) {
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.CompareTag ("Bread")) {
			StartCoroutine(ToastBread(collidedWith));
		} else if (collidedWith.CompareTag("Toast")){
			numToasted ++;
			if (numToasted == 2){
				StartCoroutine(LaunchToast());
			}	
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
	}
}
