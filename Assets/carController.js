#pragma strict

var moveUp : KeyCode;
var moveDown : KeyCode;
var moveLeft : KeyCode;
var moveRight : KeyCode;

var speed : float =  10;
var hinge : HingeJoint2D;

function Start ()
{
hinge = GetComponent (HingeJoint2D);
}


function Update () {

	if(Input.GetKey(moveUp)){
		hinge.motor.motorSpeed = 1000;
	}else if(Input.GetKey(moveDown)){
		hinge.motor.motorSpeed = -1000;
	}else if(Input.GetKey(moveRight)){
		//rigidbody2D.velocity.x = 10;
	}else if(Input.GetKey(moveLeft)){
		//rigidbody2D.velocity.x = -10;
	}else{
		hinge.motor.motorSpeed = 0;
		//rigidbody2D.velocity.x = 0;
	}
}