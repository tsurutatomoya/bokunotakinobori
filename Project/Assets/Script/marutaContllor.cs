using UnityEngine;
using System.Collections;

public class marutaContllor : MonoBehaviour {
	public GameObject m_maruta;
	private GameObject[] m_ismaruta = new GameObject[10];
	private int m_index;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// マイフレーム1/100でオブジェクトを出してみる
		if (Random.Range(0, 100) == 0) {
			// オブジェクトの生成
			for (int i = 0; i < 10; i++) {
				// 使っていないオブジェクトを探す
				if (m_ismaruta[i] == null) {
					// インスタンスを生成
					m_ismaruta[i] = (GameObject)Instantiate (m_maruta);
					break;		// 生成したら抜ける
				}
			}
		}
	}
}
