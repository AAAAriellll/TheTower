using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetAsset : MonoBehaviour
{
    public GameObject tarAsset;
    public GameObject tarGet;
    // Start is called before the first frame update
    
    private void OnMouseUp()
    {
        tarAsset.SetActive(true);
        tarGet.SetActive(false);

    }
}
