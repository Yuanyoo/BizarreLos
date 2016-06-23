using UnityEngine;
using System.Collections;

public class MeleeAttackDown : MonoBehaviour 
{
	public GameObject attack;
	void Update()
	{
		
		if(Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.W))
		{
			attack.SetActive(true);
		}

		else
		{
			attack.SetActive(false);
		}

	}

}