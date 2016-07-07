using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour {

	// Use this for initialization

	Vector3 playerPos;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
	
		Destroy( gameObject);

	}

	void NailedIt(){
		print ("Rock on dude!");
	}
}
