using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//1フレーム前のタッチのポジションｘ
	float beforeTouchPos_x;

	public static int hp = 3; 

	// Use this for initialization
	void Start () {
		//位置の初期化
		this.transform.position = new Vector3 (0.0f,-3.2f, 0);

		hp = 3;

		//1フレーム前のタッチポジションの保持
		beforeTouchPos_x = 0.0f;
	}

	// Update is called once per frame
	void Update () {

		//クリックされているなら
		if (Input.GetMouseButton(0))
		{
			//クリック開始時なら
			if(beforeTouchPos_x == 0.0f)
			{
				beforeTouchPos_x = Input.mousePosition.x;
			}
			else
			{
				//1フレーム前のタッチ座標より、タッチ座標が小さいなら
				if (beforeTouchPos_x > Input.mousePosition.x)
				{
					if(this.transform.position.x - 0.1 >= -2.3f)
						this.transform.position += new Vector3(-0.15f,0.0f,0.0f);
				}
				//1フレーム前のタッチ座標より、タッチ座標が大きいなら
				else if(beforeTouchPos_x < Input.mousePosition.x)
				{
					if(this.transform.position.x + 0.1 <= 2.1f)
						this.transform.position += new Vector3(0.15f,0.0f,0.0f);
				}

				//今回のポジションｘを保持
				beforeTouchPos_x = Input.mousePosition.x;
			}
		}
/*
		//クリックを離したなら
		if (Input.GetMouseButtonUp(0))
		{
			hp--;

			//1フレーム前のタッチポジションｘを初期化
			beforeTouchPos_x = 0.0f;
		}
*/	}

}
