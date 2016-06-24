using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

	public float movespeed = 0.1f;

	void Update ()
	{
		
		if (Input.GetKey (KeyCode.RightArrow)) 
			transform.position += new Vector3 (movespeed*Time.deltaTime, 0.0f, 0.0f);

		if (Input.GetKey (KeyCode.LeftArrow)) 
			transform.position -= new Vector3 (movespeed*Time.deltaTime, 0.0f, 0.0f);
	
	}
}
