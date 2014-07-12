using UnityEngine;
using System.Collections;


public class button : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Player.hp <= 0) 
		{
			renderer.enabled = true;

			if (Input.GetMouseButtonDown(0))
			{
			
				Debug.Log("test");
				Application.LoadLevel("title");
			}


		}
	}
}
