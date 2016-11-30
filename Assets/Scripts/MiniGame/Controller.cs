using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject instructions;
    [SerializeField]
    private GameObject quit;
    private bool isOn;
    private bool exit;
    // Use this for initialization
    void Start()
    {
        isOn = false;
        exit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!exit)
        {
            if (Input.GetKeyDown("p"))
            {
                isOn = !isOn;
                instructions.SetActive(isOn);
                menu.SetActive(!isOn);
            }

            if (Input.GetKeyDown("q"))
            {
                quit.SetActive(true);
                instructions.SetActive(false);
                menu.SetActive(false);
                Time.timeScale = 0;
                exit = true;
            }
        }
        else
        {
            if (Input.GetKeyDown("y"))
            {
                SceneManager.LoadScene("Truck");
                Time.timeScale = 1;
            }
            if (Input.GetKeyDown("n"))
            {
                Time.timeScale = 1;
                exit = false;
                quit.SetActive(false);
                instructions.SetActive(isOn);
                menu.SetActive(!isOn);

            }
        }
    }
}
    

