using UnityEngine;
public class Test_Win : MonoBehaviour
{
    public UpgradePlayer Upgrade;

    //Function for if player passes through this object. 
    private void OnTriggerStay2D(Collider2D other)
    {
        //Checks if player object contains the PlayerController script. 
        if (other.GetComponent<Test_PlayerContr>() == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Upgrade.ChangePlayer();
            }
        }
    }
}