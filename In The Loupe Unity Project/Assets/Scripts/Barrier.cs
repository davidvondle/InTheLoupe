using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision){
		PlayerMovement player=collision.gameObject.GetComponent<PlayerMovement>();
        player.canWalk=false;
    }

    void OnCollisionExit2D(Collision2D collision){
		PlayerMovement player=collision.gameObject.GetComponent<PlayerMovement>();
        player.canWalk=true;
    }
}
