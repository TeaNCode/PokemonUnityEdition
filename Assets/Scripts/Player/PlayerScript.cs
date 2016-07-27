using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private Animator animator;
    private int movementStateHash = Animator.StringToHash("MovementState");
    private float movementTimer;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.SetFloat(movementStateHash, .3f);
        movementTimer = 0;
        direction = Vector3.zero;

	}
	
	// Update is called once per frame
	void Update () {
        movementTimer -= Time.deltaTime * 4;
        if(movementTimer > 0)
        {
            transform.Translate(direction * 4 * Time.deltaTime);
        }
        else if (movementTimer <= 0f)
        {
            roundLocation();
            if (Input.GetKey(KeyCode.W))
            {
                roundLocation();
                direction = Vector3.up;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1.1f);
                movementTimer = 1f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                roundLocation();
                direction = Vector3.down;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1f);
                movementTimer = 1f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
               roundLocation();
                direction = Vector3.right;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1.2f);
                movementTimer = 1f;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                roundLocation();
                direction = Vector3.left;
                transform.Translate(direction * 4 * Time.deltaTime);
                animator.SetFloat(movementStateHash, 1.3f);
                movementTimer = 1f;
            }
            else
            {
                roundLocation();
                if (animator.GetFloat(movementStateHash) >= 1)
                {
                    animator.SetFloat(movementStateHash, animator.GetFloat(movementStateHash) - 1f);
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        roundLocation();
    }

    private void roundLocation()
    {
        Vector3 location = transform.position;
        int xGoal = Mathf.RoundToInt(location.x);
        int yGoal = Mathf.RoundToInt(location.y);
        float xDistance = xGoal - location.x;
        float yDistance = yGoal - location.y;
        transform.Translate(new Vector3(xDistance, yDistance, 0));
    }
}
