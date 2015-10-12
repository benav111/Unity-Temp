using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {

	// Use this for initialization
	public float walkSpeed = 2.0f;
	public float wallLeft = GameObject.Find("Enemy").transform.position.x- 2.0f;
	public float wallRight = GameObject.Find("Enemy").transform.position.x+ 2.0f;
	float walkingDirection = 1.0f;
	Vector3 walkAmount;
	// Update is called once per frame
	void Update () {
		walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
		if (walkingDirection>0.0f && transform.position.x >=wallRight)
		{//switch directions	
			walkingDirection = -1.0f;
		}
		else if (walkingDirection < 0.0f && transform.position.x <= wallLeft)
		{//switch directions
			walkingDirection = 1.0f;
		}
		transform.Translate(walkAmount);
	}
}
