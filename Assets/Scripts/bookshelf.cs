using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class bookshelf : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnMouseUp()
    {
        Debug.Log("switch");
        SceneManager.LoadScene("bookshelf");
    }

    // Update is called once per frame

}
