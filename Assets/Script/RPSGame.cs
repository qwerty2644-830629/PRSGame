using UnityEngine;
using TMPro;

public class RPSGame : MonoBehaviour
{
    public TextMeshProUGUI playerPick;
    public TextMeshProUGUI NPCPick;
    public TextMeshProUGUI Result;

    //猜拳
    public void GameStart(int iIndex)
    {
        int NPCIndex = Random.Range(0, 3);

        if (NPCIndex == 0)
        {
            NPCPick.text = "剪刀";
        }
        else if (NPCIndex == 1)
        {
            NPCPick.text = "石頭";
        }
        else if (NPCIndex == 2)
        {
            NPCPick.text = "布";
        }

        if (iIndex == 0)
        {
            playerPick.text = "剪刀";
        }
        else if (iIndex == 1)
        {
            playerPick.text = "石頭";
        }
        else if (iIndex == 2)
        {
            playerPick.text = "布";
        }

        if (iIndex == NPCIndex)
        {
            Result.text = "平手";
        }
        else if ((iIndex == 0 && NPCIndex == 2) ||
                (iIndex == 1 && NPCIndex == 0) ||
                (iIndex == 2 && NPCIndex == 1)) 
        {
            Result.text = "勝利";
        }
        else
        {
            Result.text = "失敗";
        }

    }

    //Reset
    public void ResetGame()
    {
        playerPick.text = "player出拳";
        NPCPick.text = "NPC出拳";
        Result.text = "結果";
    }

}
