using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wineDown : MonoBehaviour
{
    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public GameObject key;
    int iW = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(iW==1)
        {
            w1.SetActive(false);
        }
        if (iW == 2)
        {
            w2.SetActive(false);
        }
        if (iW == 3)
        {
            w3.SetActive(false);
        }
        if (iW == 4)
        {
            w4.SetActive(false);
            
        }
    }
    private void OnMouseUp()
    {
        iW++;
        //Debug.Log(iW);
        if(iW==4)
        {
            key.transform.position = new Vector2(key.transform.position.x, key.transform.position.y + 1.5f);
        }
    }
}
