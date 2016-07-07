using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Board : MonoBehaviour {
	public Transform piece;
	private int xLength = 4;
	private int yLength = 4;
	private List<List<GameObject>> field = new List<List<GameObject>>(4);
	// Use this for initialization
	void Start () {
		foreach( int xPos in Enumerable.Range( 0, xLength ) ){


			List<GameObject> yList = new List<GameObject>();
			int yDist = 0;
			foreach( int yPos in Enumerable.Range(0, yLength)){

				GameObject go;
				go=Instantiate(piece.gameObject) as GameObject;
				go.transform.position = new Vector3(xPos*60,yPos*60);
				yList.Add(go);
			}
			field.Add(yList);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
