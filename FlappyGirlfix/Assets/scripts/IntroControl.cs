using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroControl: MonoBehaviour {


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
   
	
	
	
	private Rigidbody2D myRigidbody;


	
	
	private Collider2D myCollider;
	
	
	public IntroManager IntroManager;

    public AudioSource jumpSound;
    public AudioSource deathSound;






    // Use this for initialization
    void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D>();
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


        


        if (Input.GetKeyDown(KeyCode.Space) )

        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            jumpSound.Play();

        }
		
		
		if (Input.GetKey(KeyCode.Space))
		{
			if(jumpTimeCOunter > 0)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
			jumpTimeCOunter -= Time.deltaTime;
        }
		}
		
		
		if(Input.GetKeyUp (KeyCode.Space))
		{
			jumpTimeCOunter = 0;
            jumpSound.Play();
        }
		
		if (grounded)
		{
			jumpTimeCOunter = jumpTime;
		}
		
		
		
		
		//animaatiojuuttuja
		
		
		

            if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            
        }
		
			
		
	}
	
	
	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.gameObject.tag == "killbox"){

            IntroManager.RestartGame1();
            
            moveSpeed = moveSpeedStore;
			speedMilestoneCount = speedMilestoneCountStore;
			speedIncreaseMilestone = speedIncreaseMilestoneStore;
            deathSound.Play();
        }
	}

	
	
}
