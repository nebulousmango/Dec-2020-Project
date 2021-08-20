using UnityEngine;
public class Test_Win : MonoBehaviour
{
    public UpgradePlayer Upgrade;
    bool WinTriggerEntered = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && WinTriggerEntered)
        {
            Upgrade.ChangePlayer();
        }
    }

    //Function for if player passes through this object. 
    private void OnTriggerStay2D(Collider2D other)
    {
        //Checks if player object contains the PlayerController script. 
        if (other.GetComponent<Test_PlayerContr>() == true)
        {
                WinTriggerEntered = true;
        }
    }
}