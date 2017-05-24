using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wikitude;

public class dinoController : MonoBehaviour {

	//create an instant tracker controller 
	private InstantTrackerController trackerScript;

	private GameObject ButtonsParent;

	private GridRenderer grid;

	void Awake()
	{

	}
	// Use this for initialization
	void Start () {


		//refrence the instant tracker controller from the controller component
		trackerScript = GameObject.Find ("Controller").gameObject.GetComponent<InstantTrackerController>();
		//refrence the buttons parent 
		ButtonsParent = GameObject.Find("Buttons Parent");
		grid = GameObject.Find ("Controller").gameObject.GetComponent<GridRenderer> ();
		//disable grid and buttons are disbaled when the dinosaur is instanciated
		grid.enabled = false;
		ButtonsParent.SetActive (false);
	}

	//use enable function to remove grid and button when tracking 
	void OnEnable()
	{
		grid.enabled = false;
		ButtonsParent.SetActive (false);
	}

	//use disable function to display button when no longer tracking

	void OnDisable()
	{
		ButtonsParent.SetActive (true);
	}
}
