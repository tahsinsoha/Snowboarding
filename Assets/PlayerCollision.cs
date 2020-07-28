  using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMove movement;
           // public GameManager gameManager;
	void OnCollisionEnter (Collision collisionInfo)
	{

		if(collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
                         
                           Application.LoadLevel (Application.loadedLevel);
		
		
}

}
}