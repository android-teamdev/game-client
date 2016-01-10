using UnityEngine;
using System.Collections;

public class TileCubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0f, Time.deltaTime * 10.0f, 0f));
		transform.Rotate (new Vector3 (Time.deltaTime * 12.0f, 0f,  0f));
		transform.Rotate (new Vector3 (0f, 0f, Time.deltaTime * 3.0f));
	}

}
