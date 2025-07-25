using UnityEngine;
using TMPro;

public class AtuoRPSGame : MonoBehaviour
{
    public TextMeshProUGUI Result1;
    public int NPC1Win, NPC2Win, draw = 0;

    //猜拳

    public void TenTime()
    {
        NPC1Win = 0;
        NPC2Win = 0;
        draw = 0;
        for (int i = 0; i < 10; i++)
        {
            
            int NPC1Index = Random.Range(0, 3);
            int NPC2Index = Random.Range(0, 3);

            if (NPC1Index == NPC2Index)
            {
                draw++;
            }
            else if ((NPC1Index == 0 && NPC2Index == 2) ||
                    (NPC1Index == 1 && NPC2Index == 0) ||
                    (NPC1Index == 2 && NPC2Index == 1)) 
            {
                NPC1Win++;
            }
            else
            {
                NPC2Win++;
            }
        }
        Result1.text = "NPC1贏了" + NPC1Win + "次" + "\nNPC2贏了" + NPC2Win + "次" + "\n平手" + draw + "次";
    }
    public void OneTime()
    {   
        NPC1Win = 0;
        NPC2Win = 0;
        draw = 0;
        int NPC1Index = Random.Range(0, 3);
        int NPC2Index = Random.Range(0, 3);

        if (NPC1Index == NPC2Index)
        {
            draw++;
        }
        else if ((NPC1Index == 0 && NPC2Index == 2) ||
                (NPC1Index == 1 && NPC2Index == 0) ||
                (NPC1Index == 2 && NPC2Index == 1)) 
        {
            NPC1Win++;
        }
        else
        {
            NPC2Win++;
        }
        Result1.text = "NPC1贏了" + NPC1Win + "次" + "\nNPC2贏了" + NPC2Win + "次" + "\n平手" + draw + "次";
    }

    //Reset
    public void ResetGame()
    {
        Result1.text = "結果";

    }

}

