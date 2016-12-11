using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlController : MonoBehaviour {
    [SerializeField]
    private GameObject car;
    [SerializeField]
    private GameObject Waypoint1;
    [SerializeField]
    private GameObject Waypoint2;
    [SerializeField]
    private GameObject Waypoint3;
    [SerializeField]
    private GameObject Waypoint4;
    [SerializeField]
    private GameObject Waypoint5;
    [SerializeField]
    private GameObject Waypoint6;
    [SerializeField]
    private float duration;

    private Vector3 currentPoint;
    private Vector3 nextPoint;
    private float startTime;

    // Use this for initialization
    void Start () {
        currentPoint = Waypoint1.transform.position;
        nextPoint = Waypoint2.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void moveCar()
    {
        startTime = Time.time;
        car.transform.position = Vector3.Lerp(currentPoint, nextPoint, (Time.time - startTime) / duration);
        
    }
}
