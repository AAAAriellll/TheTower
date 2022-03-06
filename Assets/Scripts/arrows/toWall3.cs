using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toWall3 : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnMouseUp()
    {
        SceneManager.LoadScene("wall3(table)");
    }
    private void OnMouseEnter()
    {
        transform.localScale += Vector3.one * 0.07f;
    }
    private void OnMouseExit()
    {
        transform.localScale -= Vector3.one * 0.07f;
    }
}
