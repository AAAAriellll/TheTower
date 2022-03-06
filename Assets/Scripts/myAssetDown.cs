using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myAssetDown : MonoBehaviour
{
    public GameObject myAsset;
    public GameObject arrowDown;
    public GameObject arrowUp;
    public GameObject destination;
    public GameObject Seed;
    public GameObject Chain;
    public GameObject Jewel;
    public GameObject Glasses;
    public GameObject Key;
    // Start is called before the first frame update
    
    private void OnMouseUp()
    {
        Debug.Log("clicked");
        arrowUp.SetActive(true);
        myAsset.transform.position = Vector2.MoveTowards(myAsset.transform.position, destination.transform.position, 1.7f);
        arrowDown.transform.position = Vector2.MoveTowards(arrowDown.transform.position, destination.transform.position, 1.7f);
        Seed.transform.position = new Vector2(Seed.transform.position.x, Seed.transform.position.y - 1.7f);
        Chain.transform.position = new Vector2(Chain.transform.position.x, Chain.transform.position.y - 1.7f);
        Jewel.transform.position = new Vector2(Jewel.transform.position.x, Jewel.transform.position.y - 1.7f);
        Glasses.transform.position = new Vector2(Glasses.transform.position.x, Glasses.transform.position.y - 1.7f);
        Key.transform.position = new Vector2(Key.transform.position.x, Key.transform.position.y - 1.7f);
       

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
