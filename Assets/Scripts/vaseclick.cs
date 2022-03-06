using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaseclick : MonoBehaviour
{
    public GameObject fragment;
    public GameObject vase;
    public GameObject seed;
    // Start is called before the first frame update
    
    private void OnMouseUp()
    {
        seed.SetActive(true);
        fragment.SetActive(true);
        vase.SetActive(false);
    }
}
