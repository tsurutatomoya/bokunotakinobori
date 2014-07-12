using UnityEngine;
using System.Collections;

public class titleChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 特定キー
		if (Input.anyKey)
		{
			Debug.Log("test");
			Application.LoadLevel("game");
		}

		if(Input.GetButton("Jump")) {
//			Application.LoadLevel("game");
		}
	}
}
