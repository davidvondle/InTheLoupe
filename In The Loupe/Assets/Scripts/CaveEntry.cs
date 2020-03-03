using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveEntry : MonoBehaviour {
	GameObject caveMap;

	void OnTriggerEnter2D(Collider2D other){
		if(Manager.Instance.inCave){//going out
			Manager.Instance.caveMap.SetActive(false);
			Manager.Instance.surfaceMap.SetActive(true);
			Manager.Instance.surfaceBkgnd.SetActive(true);
		}else{//going in
			//player=other.gameObject.GetComponent<PlayerMovement>();
			Manager.Instance.caveMap.SetActive(true);
			Manager.Instance.surfaceMap.SetActive(false);
			Manager.Instance.surfaceBkgnd.SetActive(false);
		}
   }

   void OnTriggerExit2D(Collider2D other){
		if(Manager.Instance.inCave){//going out
			Manager.Instance.inCave=false;
		}else{//going in
			Manager.Instance.inCave=true;
		}
   }
}
