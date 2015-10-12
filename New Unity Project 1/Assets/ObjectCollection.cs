using UnityEngine;
using System.Collections;

public class ObjectCollection : MonoBehaviour {
	//DONT LEAVE THIS VARIABLE HERE, MOVE WITH UPDATE INFO TO MAIN SCRIPT
	bool endGame = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//PUT THIS IN MAIN SCRIPT, DONT LEAVE IN THIS ONE, ALSO TAKE THE VARIABLE ENDGAME 
		//if there are no more collectables yet, this tag is arbitrary, then end the game
		if (GameObject.FindGameObjectsWithTag ("Cube").Length == 0) 
		{
			endGame = true;
		}
		if (endGame == true)
		{
			//ENTER WHAT YOU WANT TO HAPPEN WHEN THE GAME ENDS HERE.
		}
	}
	//if collides with player, destroy cube
	void OnCollisionEnter (Collision col)
	{	/*THE PLAYER MUST BE TAGGED AS SUCH	
		THIS PREVENTS THE COLLECTABLE FROM ACCIDENTALLY BEING
		DESTROYED BY OTHER OBJECTS*/
		if(col.gameObject.name == "Player")
		{
			Destroy(this.gameObject);
		}
	}
