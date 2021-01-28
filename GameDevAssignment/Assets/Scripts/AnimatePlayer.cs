using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    //Adding Unity slot to set player animator. 
    public Animator Animator_Player;

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.D))
        {
            Animator_Player.SetBool("Walk_W", false);
            Animator_Player.SetBool("Walk_A", false);
            Animator_Player.SetBool("Walk_S", false);
            Animator_Player.SetBool("Walk_D", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Setting player's Animator component's bool to true. 
            Animator_Player.SetBool("Walk_D", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Setting player's Animator component's bool to true. 
            Animator_Player.SetBool("Walk_A", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //Setting player's Animator component's bool to true. 
            Animator_Player.SetBool("Walk_W", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Setting player's Animator component's bool to true. 
            Animator_Player.SetBool("Walk_S", true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<WinState>() == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Animator_Player.SetTrigger("Upgrade");
            }
        }

    }
}
