using UnityEngine;
using System;

public class Countup : MonoBehaviour
{	
	public float startTime = 0.0f; // seconds
	public float timer;
	public bool paused = true;
	
	private void Start()
	{
		reset();
	}
	
	private void reset()
	{
		timer = startTime;
		paused = false;
	}
	
	private void Update()
	{

		if (Player.hp > 0) 
		{
			if (paused) return;
			timer += Time.deltaTime;
		}
			/*
		if (timer <= 0.0f)
		{
			timer = 0.0f;
			paused = true;
			
			// 何かの処理
		}
		*/
	}
	
	private void OnGUI()
	{
/*
		GUILayout.BeginArea (new Rect (270, 20, 200, 500));

		GUILayout.BeginVertical(GUILayout.Width(100));
		GUILayout.Box(String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(timer / 3600f), Math.Floor(timer / 60f), Math.Floor(timer % 60f), timer % 1 * 100), GUILayout.Width(100));
		GUILayout.Space (100);
		GUILayout.BeginHorizontal();		
		if (GUILayout.Button("Start")) paused = false;

		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		GUILayout.EndArea();
/*/
		GUILayout.BeginArea (new Rect (0, 0, Screen.width, Screen.height));
		GUILayout.Space (20);
		//GUILayout.FlexibleSpace ();
				GUILayout.BeginHorizontal ();
					GUILayout.FlexibleSpace ();
					GUILayout.BeginVertical(GUILayout.Width(100));

						// Timer.
						//GUILayout.FlexibleSpace ();
						GUILayout.Box(String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(timer / 3600f), Math.Floor(timer / 60f), Math.Floor(timer % 60f), timer % 1 * 100), GUILayout.Width(100));
						GUILayout.FlexibleSpace ();

						// Start.
//						GUILayout.FlexibleSpace ();
//						if (GUILayout.Button("Start")) paused = false;
//						GUILayout.FlexibleSpace ();

					GUILayout.EndVertical();
					GUILayout.FlexibleSpace ();
				GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace ();
		GUILayout.EndArea();
		//*/


/*
		GUILayout.BeginHorizontal();		
		if (GUILayout.Button("Start")) paused = false;
		if (GUILayout.Button("Stop")) paused = true;
		if (GUILayout.Button("Reset")) reset();
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		GUILayout.EndArea();
*/
	}
}
