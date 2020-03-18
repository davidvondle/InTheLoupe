using UnityEngine;

public class Manager : MonoBehaviour {
	public static Manager Instance{get; private set;}

	public GameObject caveMap;
	public GameObject surfaceMap;
	public GameObject surfaceBkgnd;
	public GameObject homeMap;
	public GameObject homeBkgnd;
	public bool inCave = false;

	// Use this for initialization
	private void Awake () {
		if(Instance == null){
			Instance =this;
			DontDestroyOnLoad(gameObject);
		}else{
			Destroy(gameObject);
		}
		
	}

	private void Start () {
		caveMap = GameObject.Find("Cave");
		surfaceMap = GameObject.Find("Surface");
		surfaceBkgnd = GameObject.Find("SurfaceBkgnd");
		homeMap = GameObject.Find("Home");
		homeBkgnd = GameObject.Find("HomeBkgnd");

		caveMap.SetActive(false);
		homeMap.SetActive(false);
		homeBkgnd.SetActive(false);
	}
}
