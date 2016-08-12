using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour {

    private Animator animator;
    private int movementStateHash = Animator.StringToHash("MovementState");
    private float movementTimer;
    private Rigidbody2D body;

    public static ushort trainerID;
    public static ushort secretID;
    public static String playerName;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.SetFloat(movementStateHash, .3f);
        movementTimer = 0;
        body = GetComponent<Rigidbody2D>();
        System.Random random = new System.Random();
        Byte[] bytes = new Byte[4];
        random.NextBytes(bytes);
        trainerID = BitConverter.ToUInt16(bytes, 0);
        secretID = BitConverter.ToUInt16(bytes, 2);
        playerName = "Nathan";
	}
	
	// Update is called once per frame
	void Update () {
        movementTimer -= Time.deltaTime * 4;
        if (movementTimer <= 0f)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            roundLocation();
            if (vertical < 0f)
            {
                body.velocity = new Vector2(0, -4);
                animator.SetFloat(movementStateHash, 1f);
                movementTimer = 1f;
            }
            else if (horizontal < 0f)
            {
                body.velocity = new Vector2(-4, 0);
                animator.SetFloat(movementStateHash, 1.3f);
                movementTimer = 1f;
            }
            else if(vertical > 0f)
            {
                body.velocity = new Vector2(0, 4);
                animator.SetFloat(movementStateHash, 1.1f);
                movementTimer = 1f;
            }
            else if (horizontal > 0f)
            {
                body.velocity = new Vector2(4, 0);
                animator.SetFloat(movementStateHash, 1.2f);
                movementTimer = 1f;
            }
            else 
            {
                if(body.velocity != Vector2.zero)
                {
                    body.velocity = Vector2.zero;
                }
                if (animator.GetFloat(movementStateHash) >= 1)
                {
                    animator.SetFloat(movementStateHash, animator.GetFloat(movementStateHash) - 1f);
                }
            }
        }
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
