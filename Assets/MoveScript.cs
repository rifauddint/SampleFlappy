using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
	
		public float speedX;	


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				rigidbody2D.velocity = new Vector2 (speedX, 0);
				if (gameObject.transform.position.x < -4) {
						gameObject.transform.position = new Vector3 (4, 0, 10);
				
				}
		}
}
