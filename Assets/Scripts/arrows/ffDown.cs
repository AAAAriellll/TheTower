using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ffDown : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnMouseUp()
    {
        Debug.Log("switch");
        SceneManager.LoadScene("wall1(bookshelf)");
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
