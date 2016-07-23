using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private Animator animator;
    private int movementStateHash = Animator.StringToHash("MovementState");

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.SetFloat(movementStateHash, .3f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 5 * Time.deltaTime);
            animator.SetFloat(movementStateHash, 1.1f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 5 * Time.deltaTime);
            animator.SetFloat(movementStateHash, 1f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
            animator.SetFloat(movementStateHash, 1.2f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
            animator.SetFloat(movementStateHash, 1.3f);
        }
        else if(animator.GetFloat(movementStateHash) >= 1)
        {
            animator.SetFloat(movementStateHash, animator.GetFloat(movementStateHash) - 1f);
        }
    }
}
