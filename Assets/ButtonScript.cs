using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{

		public GameObject bird;
			
		void  Start ()
		{
				bird = GameObject.Find ("bird");
	
		}

		void OnMouseDown ()
		{
				if (GameManager.gamestatus == GameManager.GameStatus.Wait) {
						GameManager.gamestatus = GameManager.GameStatus.Play;
				}
	
				if (GameManager.gamestatus == GameManager.GameStatus.Play) {
						bird.GetComponent<PlayerScript> ().Jump ();
				}
				if (GameManager.gamestatus == GameManager.GameStatus.GameOver) {
				
						Application.LoadLevel ("Game");
				}
		}
}
