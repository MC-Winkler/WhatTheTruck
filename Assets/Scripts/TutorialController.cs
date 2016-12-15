using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour {
	[SerializeField]
	private GameObject tutorial;
	[SerializeField]
	private GameObject Movement;
	[SerializeField]
	private GameObject rotation;
	[SerializeField]
	private GameObject grab;
	[SerializeField]
	private GameObject NextTask;
	[SerializeField]
	private GameObject menu;
	[SerializeField]
	private GameObject instructions;
	[SerializeField]
	private GameObject quit;
	[SerializeField]
	private GameObject pause;
	[SerializeField]
	private GameObject controls;
	[SerializeField]
	private GameObject end;
	[SerializeField]
	private GameObject droppedFood;
	private bool timeOn;

	void Start()
	{
		tutorial.SetActive (true);
		menu.SetActive (true);
		quit.SetActive (false);
		controls.SetActive (false);
		end.SetActive (false);
		pause.SetActive (false);
		droppedFood.SetActive (false);
		timeOn = true;
		//Cursor.visible = false;
		//Cursor.lockState = CursorLockMode.Locked;

	}

	public void ControlMenu(){
		pause.SetActive (false);
		controls.SetActive (true);
	}

	public void QuitMenu(){
		pause.SetActive (false);
		quit.SetActive (true);
	}

	public void DroppedFood(){
		menu.SetActive (false);
		instructions.SetActive (false);
		StartCoroutine (dFood ());

	}

	IEnumerator dFood(){

		droppedFood.SetActive (true);
		yield return new WaitForSeconds (2);
		droppedFood.SetActive (false);
		menu.SetActive (true);
		instructions.SetActive (true);
	}

	public void Continue(){
		timeOn = !timeOn;
		Time.timeScale = 1;
		menu.SetActive (true);
		instructions.SetActive (true);
		pause.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void QuitNo(){
		quit.SetActive (false);
		pause.SetActive (true);
	}

	public void QuitYes(){
		quit.SetActive (false);
		Time.timeScale = 1;
		SceneManager.LoadScene ("StartScene");
	}

	public void EndScene(){
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		Time.timeScale = 0;
		end.SetActive (true);
		menu.SetActive (false);
		instructions.SetActive (false);
	}

	public void MoveToNextScene(){
		int nextScene = SceneManager.GetActiveScene().buildIndex +1;
		SceneManager.LoadScene (nextScene);
		Time.timeScale = 1;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void StartGame(){
		SceneManager.LoadScene ("Tutorial");
		Time.timeScale = 1;
		Cursor.visible = false;
	}

	public void EndSceneContinue(){
		SceneManager.LoadScene ("StartScene");
	}

	public void ControlsBack(){
		controls.SetActive (false);
		pause.SetActive (true);
	}
	// Update is called once per frame
	void Update()
	{
		//timeLeft -= Time.deltaTime;
		//timerText.text = Mathf.RoundToInt(timeLeft).ToString();
		//if (timeLeft < 0) {
		//	EndScene ();
	//	}

		if (timeOn) {
			if (Input.GetKey (KeyCode.Escape)) {
				timeOn = !timeOn;
				Time.timeScale = 0;
				menu.SetActive (false);
				pause.SetActive (true);
				instructions.SetActive (false);
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
		} 
	}
}
