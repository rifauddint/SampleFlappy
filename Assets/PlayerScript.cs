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
			
				}
		
		}

}


