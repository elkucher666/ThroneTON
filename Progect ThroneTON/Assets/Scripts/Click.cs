using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Textcounter;
    public Image Wall;
    int counter;
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            counter++;
            Textcounter.text = counter.ToString();
            RandomColor();
        }
    }
    public void RandomColor()
    {
        Wall.color = new Color(Random.value, Random.value, Random.value);
    }
}
