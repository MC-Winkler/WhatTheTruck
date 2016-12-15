using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
	[SerializeField]
	private GameObject tutorial;
	[SerializeField]
	private GameObject movement;
	[SerializeField]
	private GameObject rotation;
	[SerializeField]
	private GameObject grab;
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
	public Text timerText;
	private float timeLeft = 120.0f;

    // Use this for initialization
    void Start()
    {
		Scene scene = SceneManager.GetActiveScene ();
		if (scene == SceneManager.GetSceneByName ("Tutorial")) {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			TutorialStart ();

		} else {
			StartTheScene ();
		}
    }

	public void TutorialStart(){
		tutorial.SetActive (true);
		Cursor.visible = true;
		Time.timeScale = 0;
		Cursor.lockState = CursorLockMode.None;

	}

	public void TutorialStartButton(){
		tutorial.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		menu.SetActive (true);
		Time.timeScale = 1;
		timeOn = true;
		StartCoroutine (TutorialInstructions ());
	}

	IEnumerator TutorialInstructions(){
		movement.SetActive (true);
		yield return new WaitForSeconds (7);
		movement.SetActive (false);
		rotation.SetActive (true);
		yield return new WaitForSeconds (7);
		rotation.SetActive (false);
		grab.SetActive (true);
		yield return new WaitForSeconds (7);
		grab.SetActive (false);
		instructions.SetActive (true);
	}
	public void StartTheScene(){
		menu.SetActive (true);
		instructions.SetActive (true);
		quit.SetActive (false);
		controls.SetActive (false);
		end.SetActive (false);
		pause.SetActive (false);
		droppedFood.SetActive (false);
		timeOn = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
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
		if (timeLeft < 0) {
			EndScene ();
		}

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


