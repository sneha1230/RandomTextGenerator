using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int clickCount;
    [SerializeField] Text clickCountText;
    Enemy rand = new Enemy();
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))


        {
            //Increment();
        }

    }
    public void Increment()
    {
        clickCount++;
        clickCountText.text = clickCount.ToString();
        clickCountText.text = rand.Generator(clickCount);
    }
}
