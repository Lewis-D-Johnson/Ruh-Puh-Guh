using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float MovementSpeed;
	Rigidbody2D rb;

    void Start()
    {
		rb = GetComponent<Rigidbody2D>();    
    }
	
    void Update()
    {
		//Movement
		rb.velocity = new Vector2(Input.GetAxis("Horizontal") * MovementSpeed, Input.GetAxis("Vertical") * MovementSpeed);

		#region Bounds Section
		//Bounds [This is to prevent the player from breaching the bounds of the map.]
		if (transform.position.x > 450)
			transform.position = new Vector3(450, transform.position.y);

		if (transform.position.x < -450)
			transform.position = new Vector3(-450, transform.position.y);

		if (transform.position.y > 280)
			transform.position = new Vector3(transform.position.x, 280);

		if (transform.position.y < -280)
			transform.position = new Vector3(transform.position.x, -280);
		#endregion
	}
}
