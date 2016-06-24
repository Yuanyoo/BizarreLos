using UnityEngine;
using System.Collections;

/// <summary>
/// Add this class to a character so it can do melee attacks
/// </summary>
public class CharacterMelee : MonoBehaviour 
{
	private bool allowCollision;
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		GetComponent<Collider>().enabled = true;
		if (Input.GetMouseButtonUp(0) && Physics.Raycast(ray, out hit)) 
		{
			if (hit.collider.gameObject == gameObject) 
				allowCollision = true;
		}
		GetComponent<Collider>().enabled = allowCollision;
	}

}