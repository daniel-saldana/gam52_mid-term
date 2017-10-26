using UnityEngine;
using System.Collections;

public class Fire_Cannon : MonoBehaviour 
{
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		Shoot ();
	}
	public void Shoot()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			anim.SetTrigger("Fire");
			ScoreManager.instance.score++;
		}
	}
}
