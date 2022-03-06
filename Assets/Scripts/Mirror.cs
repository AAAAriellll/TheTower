using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Mirror : MonoBehaviour
{
    public GameObject OioinMirror;

    private void OnMouseUp()
    {
        Debug.Log("clicked");
        OioinMirror.SetActive(true);
    }
}
