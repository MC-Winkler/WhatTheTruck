using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreenController : MonoBehaviour {
	[SerializeField]
	private GameObject control;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Controls(){
		control.SetActive (true);
	}

	public void Back(){
		control.SetActive (false);
	}

	public void StartGame(){
		SceneManager.LoadScene ("Tutorial");
	}

}
