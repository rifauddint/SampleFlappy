using UnityEngine;
using System.Collections;

public class MoveBGScript : MonoBehaviour {


		public float speedX;	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
				if (GameManager.gamestatus != GameManager.GameStatus.GameOver) {
						// set speed to move left
						rigidbody2D.velocity = new Vector2 (speedX, 0);
				} else {

						rigidbody2D.velocity = new Vector2 (0, 0);
				}


					if (gameObject.transform.position.x <= -19) {
						gameObject.transform.position = new Vector3 (19.2f, 0f, 11f);
			
				}

	}
}
