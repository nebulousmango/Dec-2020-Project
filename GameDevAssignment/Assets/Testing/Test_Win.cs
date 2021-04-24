using UnityEngine;
public class Test_Win : MonoBehaviour
{
    public UpgradePlayer Upgrade;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Test_PlayerContr>() == true)
        {
            Debug.Log("Please press space.");
        }
    }

    //Function for if player passes through this object. 
    private void OnTriggerStay2D(Collider2D other)
    {
        //Checks if player object contains the PlayerController script. 
        if (other.GetComponent<Test_PlayerContr>() == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("You have levelled up!");
                Upgrade.ChangePlayer();
            }
        }
    }
}