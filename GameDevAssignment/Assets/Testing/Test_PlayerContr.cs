using UnityEngine;
public class Test_PlayerContr : MonoBehaviour
{
    //Adding Unity slot to access player object's Rigidbody2D component. 
    public Rigidbody2D Rigidbody_Player;
    //Adding Unity slot to edit player's speed.  
    public float F_MoveSpeed;

    // Update is called once per frame 
    void Update()
    {
        if (!Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.D))
        {
            //Setting player's velocity to 0. 
            Rigidbody_Player.velocity = Vector2.zero;
            //Setting player's angular velocity to 0. 
        }
        //Condition for if holding down D. 
        if (Input.GetKey(KeyCode.D))
        {
            //Declaring Vector2 for moving to the right. 
            Vector2 v2_newSpeedRight = new Vector2(F_MoveSpeed, Rigidbody_Player.velocity.y);
            //Setting player's velocity to Vector2 values. 
            Rigidbody_Player.velocity = v2_newSpeedRight;
        }
        //Condition for if holding down A. 
        if (Input.GetKey(KeyCode.A))
        {
            //Declaring Vector2 for moving to the left. 
            Vector2 v2_newSpeedLeft = new Vector2(-F_MoveSpeed, Rigidbody_Player.velocity.y);
            //Setting player's velocity to Vector2 values. 
            Rigidbody_Player.velocity = v2_newSpeedLeft;
        }
        //Condition for if holding down W. 
        if (Input.GetKey(KeyCode.W))
        {
            //Declaring Vector2 for moving up.
            Vector2 v2_newSpeedUp = new Vector2(Rigidbody_Player.velocity.x, F_MoveSpeed);
            //Setting player's velocity to Vector2 values.
            Rigidbody_Player.velocity = v2_newSpeedUp;
        }
        //Condition for if holding down S.
        if (Input.GetKey(KeyCode.S))
        {
            //Declaring Vector2 for moving down.
            Vector2 v2_newSpeedDown = new Vector2(Rigidbody_Player.velocity.x, -F_MoveSpeed);
            //Setting player's velocity to Vector2 values.
            Rigidbody_Player.velocity = v2_newSpeedDown;
        }
    }
}