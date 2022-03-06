using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetShowUp : MonoBehaviour
{
    public GameObject filter;
    public GameObject words;
    public GameObject key;
    public bool iFilter=false;
    // Start is called before the first frame update
    private void OnMouseUp()
    {
        if(!iFilter)
        {
            filter.SetActive(true);
            words.SetActive(true);
            key.SetActive(true);
            iFilter = true;
        }
        else
        {
            filter.SetActive(false);
            words.SetActive(false);
            key.SetActive(false);
            iFilter = false;
        }
        
    }
}
