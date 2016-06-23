using UnityEngine;
using System.Collections;

public class Tag : MonoBehaviour
{

	public GameObject Object_1;
	public GameObject Object_2;
	public Transform player_1;
	public Transform player_2;

	void Update ()
	{
	
		if (Input.GetKeyDown (KeyCode.T))
		{
		
			Object_1.SetActive (false);
			Object_2.SetActive (true);
			player_2.position = player_1.position;

		}
	}
}
