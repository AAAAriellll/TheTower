using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDrag : MonoBehaviour
{
    public GameObject book5;
    public GameObject book4;
    public GameObject book1;
    public GameObject glasses;
    private Vector2 startPos;
    [SerializeField] private Transform transCorrect;
    [SerializeField] private bool isCorrect;//Default value is false,if isCorrect is true,stop drag.
    private void Start()
    {
        startPos = transform.position;
    }
   
    private void OnMouseDrag()
    {
        if(!isCorrect)
        {
            //MAKER SCREEN POS ->WORLD SPACE
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);

        }
        
    }
    private void OnMouseUp()
    {
        //if distance between answer and image is smaller than 0.5f,isCorrect =true
        //else go back to start Position
        if(Mathf.Abs(transform.position.x-transCorrect.position.x)<=0.5f && Mathf.Abs(transform.position.y - transCorrect.position.y) <= 0.5f)
        {
            transform.position = new Vector2(transCorrect.position.x, transCorrect.position.y);
            isCorrect = true;
            print(book5.transform.position);
            print(book4.transform.position);
            print(book1.transform.position);

            if (book5.transform.position.x - 3.4f < 0.1 &&
             book4.transform.position.x - 0.4f < 0.1 &&
             book1.transform.position.x +3.0f < 0.1) 
             //(book5.transform.position.x == 3.47f &&
             //book4.transform.position.x == 0.48f &&
             //book1.transform.position.x == -2.92f)
            {
                Debug.Log("yes");
                glasses.SetActive(true);
            }
            else
            {
                
                Debug.Log("no");
                glasses.SetActive(false);
            }
        }
        else
        {
            transform.position = new Vector2(startPos.x, startPos.y);
        }
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
