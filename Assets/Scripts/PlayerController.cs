using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	WheelJoint2D[] wheelJoints;
	JointMotor2D engine;
	public GameObject brickParticle;

	// Use this for initialization
	void Start () {
		wheelJoints = gameObject.GetComponents<WheelJoint2D>();
		engine = wheelJoints [0].motor;
//
//		wheelJoints [0].useMotor = true;
//		engine.motorSpeed = 100;


	}
	
	// Update is called once per frame
	void Update () {
//		engine.motorSpeed = 100;
//		print (engine.motorSpeed);
//
//
//		wheelJoints [0].motor = engine;

	}
	

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Something has entered this zone.");    
	} 
	void OnTriggerExit2D(Collider2D other){
		Debug.Log("Something has entered this zone.");    
	} 
	void OnTriggerStay2D(Collider2D other){
		Debug.Log("Something has entered this zone.");    
	} 
	
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "wall"){
			Debug.Log("Wall Hit");

			Instantiate(brickParticle, collision.gameObject.transform.position, Quaternion.Euler(0,0,0));

			Destroy(collision.gameObject);


			float speed = engine.motorSpeed;
			if(speed+200>0){
				engine.motorSpeed = 0;
			}else{
				engine.motorSpeed = speed+200;
			}
			wheelJoints [0].motor = engine;


		}
		//Debug.Log(collision.gameObject.tag);

	} 
}
