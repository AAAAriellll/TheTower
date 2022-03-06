using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSmall : MonoBehaviour
{
    public GameObject words;
    // Start is called before the first frame update
    
    private void OnMouseEnter()
    {
        transform.localScale += Vector3.one * 0.07f;
    }
    private void OnMouseExit()
    {
        transform.localScale -= Vector3.one * 0.07f;
    }
    private void OnMouseUp()
    {
        words.SetActive(false);
    }
}
