using UnityEngine;

public class UpgradePlayer : MonoBehaviour
{
    GameObject Player_Basic, Player_Upgrade;
    int characterSelect;
    private void Start()
    {
        characterSelect = 1;
        Player_Basic = GameObject.Find("Player_Basic");
        Player_Upgrade = GameObject.Find("Player_Upgrade");
        Player_Basic.SetActive(true);
        Player_Upgrade.SetActive(false);
    }
    public void ChangePlayer()
    {
        if (characterSelect == 1)
        {
            characterSelect = 2;
        }
        if (characterSelect == 2)
        {
            Player_Upgrade.SetActive(true);
            Player_Basic.SetActive(false);
        }
    }

}
