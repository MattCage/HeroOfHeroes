using UnityEngine;
using System.Collections;

public class RunnerController : MonoBehaviour {

    public float speed = 1.0f;
    public float jumpSpeed = 5.0f;
    public float gravity = 20.0f;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 rightDirection = Vector3.zero;
    private Vector3 jumpDirection = Vector3.zero;
    private bool grounded = false;
    

	// Use this for initialization
	void Start () {

        controller = this.gameObject.GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        if( grounded )
        {
            if( Input.GetButton( "Up" ) )
            {
                moveDirection.y = jumpSpeed;
            }
        }

        rightDirection = new Vector3( 1 * speed, 0, 0 );

        moveDirection = Vector3.RotateTowards(moveDirection, rightDirection, 200 * Mathf.Deg2Rad * Time.deltaTime, 1000);
        Vector3 movement = moveDirection * Time.deltaTime * 2;
        controller.Move(movement);

    }
}
