using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	private Animator animator;
	public Animation anim;

	// Use this for initialization
	void Start () {

		animator = this.GetComponent<Animator> ();
		anim = GetComponent<Animation>();
	
	}
	
	// Update is called once per frame
	public void stop(int n){
		
	}

	void Update () {
		
		if (Input.GetKey ("right")) {
			animator.SetInteger ("Direction", 1);
			if (Input.GetKey ("left") && Input.GetKey ("right"))
				animator.SetInteger ("Direction", 0);
			else if (Input.GetKey (KeyCode.E))
				animator.SetInteger ("Direction", 3);
		}

		if(Input.GetKeyUp("right"))
			animator.SetInteger("Direction",0);	
		
		if (Input.GetKey ("left")) {
			animator.SetInteger ("Direction", 2);
			if (Input.GetKey ("right") && Input.GetKey("left"))
				animator.SetInteger ("Direction", 0);
			else if (Input.GetKey (KeyCode.E))
				animator.SetInteger ("Direction", 3);
		}

		if(Input.GetKeyUp("left"))
			animator.SetInteger("Direction",0);	

		if (Input.GetKeyDown (KeyCode.E)) 
			animator.SetInteger ("Direction", 3);

		if (Input.GetKeyDown (KeyCode.W)) 
			animator.SetInteger ("Direction", 4);
		
		if (Input.GetKeyUp (KeyCode.W)) {
			if (Input.GetKey (KeyCode.E))
				animator.SetInteger ("Direction", 3);
		}

		if (Input.GetKeyUp (KeyCode.E)) 
			animator.SetInteger("Direction",0);	
				
		//float move = Input.GetAxis ("Horizontal");
		//animator.SetFloat ("Speed", move);
	}
}