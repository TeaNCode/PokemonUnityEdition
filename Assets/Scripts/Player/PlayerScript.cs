using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up);
            //animator.SetBool("Walk up", true);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down);
            //animator.SetBool("Walk up", false);
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
