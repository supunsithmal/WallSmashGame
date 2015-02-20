using UnityEngine;

public class ScrollingBackground : MonoBehaviour { 
	private Vector3 backPos; 
	public float width = 10.24f; 
	public float height = 0f; 
	private float X; 
	private float Y;
	public float Z;
	
	void OnBecameInvisible()
	{
		//calculate current position
		backPos = gameObject.transform.position;

		//calculate new position
		print (backPos);
		X = backPos.x + gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x*2;
		print (X);
		Y = backPos.y;
		//move to new position when invisible
		gameObject.transform.position = new Vector3 (X, Y, backPos.z);
	}



}