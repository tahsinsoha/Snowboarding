using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
           public GameObject YouWinText;
                public PlayerMove movement;
                   public float resetDelay;
	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}
	public void Win(){

          YouWinText.SetActive(true);
                Time.timeScale = .5f;
                      //Application.LoadLevel("terrain");
                     Invoke("Reset",resetDelay);

	}
void Reset(){
Time.timeScale = 1.0f;
Application.LoadLevel("terrain");


}

}
