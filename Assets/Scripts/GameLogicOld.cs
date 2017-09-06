using UnityEngine;
using System.Collections;

public class GameLogicOld : MonoBehaviour {

	public GameObject player;
	public GameObject startUI, restartUI;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void toggleUI() {
		startUI.SetActive (!startUI.activeSelf);
		restartUI.SetActive (!restartUI.activeSelf);
	}
}
