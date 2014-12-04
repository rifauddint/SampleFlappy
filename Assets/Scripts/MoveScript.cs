using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
	
		public float speedX;	
		
		/// <summary>
		/// Pengecekan penambahan score
		/// </summary>
		bool flagScore = false;
		GameObject player ;

		void Start ()
		{
				//get gameobject "player"
				player = GameObject.Find ("bird");
		}
	
		void Update ()
		{
				if (GameManager.gamestatus == GameManager.GameStatus.Play) {
						// set speed to move left
						rigidbody2D.velocity = new Vector2 (speedX, 0);
				
						//jika keluar layar
						if (gameObject.transform.position.x < -4) {
								float randomY = Random.Range (-2, 2);
								gameObject.transform.position = new Vector3 (4, randomY, 10);
						
								//set flag score
								flagScore = false;
				
						}
				
						//menambah score
						//Jika melewati player
						if (gameObject.transform.position.x < player.transform.position.x && !flagScore) {
								GameManager.score += 1;
								flagScore = true;
						}
				} else {
						rigidbody2D.velocity = new Vector2 (0, 0);
				}
				
		}
}
