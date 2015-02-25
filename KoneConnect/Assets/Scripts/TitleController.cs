using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ToGame1 () {
		Application.LoadLevel ("Stage1");
	}

	public void ToGame2 () {
		Application.LoadLevel ("Stage2");
	}

	public void ToGame3 () {
		Application.LoadLevel ("Stage3");
	}
}
