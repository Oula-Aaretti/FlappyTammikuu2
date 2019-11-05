using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour {


	public float moveSpeed;
	private float moveSpeedStore;
	public float speedMultiplier;
	
	public float speedIncreaseMilestone;
	private float speedIncreaseMilestoneStore;
	private float speedMilestoneCount;
	private float speedMilestoneCountStore;
	
	
	public float jumpForce;
	
	
	public float jumpTime;
	private float jumpTimeCOunter;
	

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool grounded;
    private bool doubleJumped;
	
	
	
	private Rigidbody2D myRigidbody;


	
	
	private Collider2D myCollider;
	
	
	private Animator myAnimator;
	
	
	public THGameManager theGameManager;

    public AudioSource jumpSound;
    public AudioSource deathSound;



    // Use this for initialization
    void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D>();
		myAnimator = GetComponent<Animator>();
		jumpTimeCOunter = jumpTime;
		speedMilestoneCount = speedIncreaseMilestone;
		moveSpeedStore = moveSpeed;
		speedMilestoneCountStore = speedMilestoneCount;
		speedIncreaseMilestoneStore = speedIncreaseMilestone;
	}
	
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

    }



	// Update is called once per frame
	void Update () {
		
		if(transform.position.x > speedMilestoneCount)
		{
			speedMilestoneCount += speedIncreaseMilestone;
			
			speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;
			
			moveSpeed = moveSpeed * speedMultiplier;
			
			
		}
		
		
		
		myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);


        if (grounded)
            doubleJumped = false;


        if (Input.GetKeyDown(KeyCode.Space) && grounded)

        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            jumpSound.Play();

        }
		
		
		if (Input.GetKey(KeyCode.Space) && grounded)
		{
			if(jumpTimeCOunter > 0)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
			jumpTimeCOunter -= Time.deltaTime;
                
            }
		}
		
		
		if(Input.GetKeyUp (KeyCode.Space) && grounded)
		{
			jumpTimeCOunter = 0;
		}
		
		if (grounded)
		{
			jumpTimeCOunter = jumpTime;
		}
		
		
		//animaatiojuuttuja
		myAnimator.SetFloat ("Speed", myRigidbody.velocity.x);
		myAnimator.SetBool ("Grounded", grounded);
		
		
		

            if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            doubleJumped = true;
            jumpSound.Play();
        }
		
			
		
	}
	
	
	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.gameObject.tag == "killbox"){
			
			theGameManager.RestartGame();
			moveSpeed = moveSpeedStore;
			speedMilestoneCount = speedMilestoneCountStore;
			speedIncreaseMilestone = speedIncreaseMilestoneStore;
            deathSound.Play();
		}
	}

	
	
}
