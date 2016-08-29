using UnityEngine;
using System.Collections;

public class BedScript : MonoBehaviour {

    public Object bedSheet;

	// Use this for initialization
	void Start () {
        Instantiate(bedSheet, new Vector3(transform.position.x + .0699f, transform.position.y + -.05f), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
