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
				scoreText.GetComponent<TextMesh> ().text = "Score :" + score;
		}
		
		
		public enum GameStatus
		{
				Wait,
				Play,
				GameOver
		
		}
}
