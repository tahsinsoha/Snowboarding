using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{

	public Transform Gameobject;
        public Text scoreText;
	
	// Update is called once per frame
	void Update ()
	{
	scoreText.text = Gameobject.position.z.ToString("0");
	}
}

