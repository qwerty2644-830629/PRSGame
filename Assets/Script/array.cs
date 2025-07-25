using UnityEngine;
using UnityEngine.UI;

public class Array : MonoBehaviour
{
    public string[] stringArray;
    public int[] intArray;
    public Sprite[] spriteArray;
    public int num = 0;
    public Image image;

    public void Start()
    {
        if(num == 10)
        {
            num = 0;
        }
        num += 1;
        image.sprite = spriteArray[num];
        
    }
    
}
