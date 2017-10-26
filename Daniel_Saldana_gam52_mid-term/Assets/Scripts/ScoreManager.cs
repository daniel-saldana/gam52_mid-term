using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance = null;

	public int score;

	void Awake ()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}
}
