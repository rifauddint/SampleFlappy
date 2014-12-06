using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

		public static int score = 0;
		public static GameStatus gamestatus;
		
		GameObject scoreText;
		
		// Use this for initialization
		void Start ()
		{
				gamestatus = GameStatus.Wait;
				score = 0;
				scoreText = GameObject.Find ("scoreText");
		}
	
		// Update is called once per frame
		void Update ()
		{	
				switch (gamestatus) {
				case GameStatus.Play:
						scoreText.GetComponent<TextMesh> ().text = "Score :" + score;
						break;
				case GameStatus.GameOver:
						scoreText.GetComponent<TextMesh> ().text = "Your Score : " + score + "\nTap To Retry";
						break;
				case GameStatus.Wait:
						scoreText.GetComponent<TextMesh> ().text = "Tap To Play";
						break;
				}
				
		}
		
		
		public enum GameStatus
		{
				Wait,
				Play,
				GameOver
		
		}
}
