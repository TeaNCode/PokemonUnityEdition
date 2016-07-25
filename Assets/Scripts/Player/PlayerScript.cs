using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private Animator animator;
    private int movementStateHash = Animator.StringToHash("MovementState");
    private float animationTimer;
    private int counter;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.SetFloat(movementStateHash, .3f);
        animationTimer = 0;
        counter = 0;
        direction = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        animationTimer -= Time.deltaTime * 4;
        if(animationTimer > 0)
        {
            transform.Translate(direction * 4 * Time.deltaTime);
        }
        if (animationTimer <= 0f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                direction = Vector3.up;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1.1f);
                animationTimer = 1f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                direction = Vector3.down;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1f);
                animationTimer = 1f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                direction = Vector3.right;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1.2f);
                animationTimer = 1f;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                direction = Vector3.left;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1.3f);
                animationTimer = 1f;
            }
            else if (animator.GetFloat(movementStateHash) >= 1)
            {
                animator.SetFloat(movementStateHash, animator.GetFloat(movementStateHash) - 1f);
            }
        }
    }
}
