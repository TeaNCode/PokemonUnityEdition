using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }
    }
}
