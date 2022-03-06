using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toWall4 : MonoBehaviour
{
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
        SceneManager.LoadScene("wall4(door)");
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
