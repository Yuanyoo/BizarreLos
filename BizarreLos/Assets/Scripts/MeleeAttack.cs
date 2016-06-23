using UnityEngine;
using System.Collections;

public class MeleeAttack : MonoBehaviour 
{
	public GameObject attack;
	void Update(){
		if(Input.GetKey(KeyCode.E)){
			attack.SetActive(true);
		}
		else{
			attack.SetActive(false);
		}

		if(Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.W))
			attack.SetActive(false);
	}
}