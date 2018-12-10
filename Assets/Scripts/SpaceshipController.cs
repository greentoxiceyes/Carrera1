using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

    public float shipSpeed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
	public float dashSpeed;

    public Vector2 minPos;
    public Vector2 maxPos;

	public float dstToGoal;

	public GameObject dashEffects;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
		Vector2 moveImput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		moveVelocity = moveImput * shipSpeed;
		Debug.Log (dstToGoal);
		dstToGoal = dstToGoal - shipSpeed*Time.deltaTime;
	

		if (Input.GetKeyDown (KeyCode.Space)) {
			moveVelocity = moveImput * dashSpeed;
		} 
			

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
