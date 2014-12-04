using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				
				if (GameManager.gamestatus == GameManager.GameStatus.Wait) {
						rigidbody2D.gravityScale = 0;
				
				} else {
						rigidbody2D.gravityScale = 2;
				}
		
		
				if (Input.GetKey (KeyCode.Space)) {
						rigidbody2D.velocity = new Vector2 (0, 5);
			
				}
		}
		
		void OnCollisionEnter2D ()
		{
				var movePipes = GameObject.FindObjectsOfType<MoveScript> ();
				
				foreach (MoveScript pipe in movePipes) {
			
						pipe.speedX = 0;
						rigidbody2D.velocity = new Vector2 (0, -5);
						pipe.collider2D.enabled = false;
						GameManager.gamestatus = GameManager.GameStatus.GameOver;
				}
		
		}

		/// <summary>
		/// use for touch call
		/// </summary>
		public void Jump ()
		{
				rigidbody2D.velocity = new Vector2 (0, 5);
		
		}
}


