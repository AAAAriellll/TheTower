using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class painting : MonoBehaviour
{
    bool bLarge=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        if(bLarge==true)
        {
            Camera.main.transform.Translate(-3.32f,2,-10);
            Camera.main.orthographicSize = 2;
            bLarge = false;
            
        }
        else
        {
            SceneManager.LoadScene("wall2(painting)");
            bLarge = true;
            
        }

    }
}
