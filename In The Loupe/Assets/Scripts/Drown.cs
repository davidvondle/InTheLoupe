using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drown : MonoBehaviour {
	

    void OnCollisionEnter2D(Collision2D collision){
		Animator anim;
	    Rigidbody2D rbody;
		PlayerMovement player;
		Vector2 finalPosition;
		Vector2 fallingInVector;

		collision.otherCollider.isTrigger=true;

        anim=collision.gameObject.GetComponent<Animator>();
        rbody=collision.gameObject.GetComponent<Rigidbody2D>();
        player=collision.gameObject.GetComponent<PlayerMovement>();
     
        player.isInCollider=true;

        fallingInVector = collision.contacts[0].normal;
        finalPosition = rbody.position + fallingInVector * 0.06f;
        finalPosition = MoveToExactPixel(finalPosition);
        rbody.MovePosition(finalPosition);

        player.isInCollider=true;
        player.fallingInVector=fallingInVector;

        anim.SetBool("isdrowning", true);
    }

    Vector2 MoveToExactPixel (Vector2 thePosition){
    	thePosition.x = (Mathf.Round(thePosition.x * 136.6f) - 0.25f) / 136.6f;
        thePosition.y = (Mathf.Round(thePosition.y * 136.6f) - 0.25f) / 136.6f;
        return thePosition;
    }

    void OnTriggerStay2D(Collider2D other){
	    Rigidbody2D rbody;
		PlayerMovement player;
		Vector2 finalPosition;
		Animator anim;

		anim=other.gameObject.GetComponent<Animator>();
		if(!anim.GetBool("isdrowning") && !anim.GetBool("isclimbingout")){
	        rbody=other.gameObject.GetComponent<Rigidbody2D>();
	        player=other.gameObject.GetComponent<PlayerMovement>();
	  
	        finalPosition = rbody.position - player.fallingInVector * 0.01f;
	        finalPosition = MoveToExactPixel(finalPosition);
	        rbody.MovePosition(finalPosition); 
	    }
	}

    void OnTriggerExit2D(Collider2D other){
		other.gameObject.GetComponent<PlayerMovement>().isInCollider=false;
		GetComponent<Collider2D>().isTrigger=false;
	}
}
