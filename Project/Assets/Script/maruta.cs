using UnityEngine;
using System.Collections;

public class maruta : MonoBehaviour {

	// Use this for initi_alization
	void Start () {
		this.transform.position = new Vector3( (Random.value * 6) - 3, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		if( layerName != "player") return;

		Destroy(gameObject);
		Player.hp--;
	}
}
