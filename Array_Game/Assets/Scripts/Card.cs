using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Card : GameManager
{

    private Collider2D myCollider;
    public Vector2 playingPos1;
    public Vector2 playingPos2;
    public Vector2 playingPos3;

    private bool canClick;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = gameObject.GetComponent<Collider2D>();
        canClick = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position == cardOnePos)
        {
            canClick = true;
        }
        if (gameObject.transform.position == cardTwoPos)
        {
            canClick = true;
        }
        if (gameObject.transform.position == cardThreePos)
        {
            canClick= true;
        }   
        else
        {
            canClick = false;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("clicking");

        if (canClick == true)
        {
            gameObject.transform.DOMove(playingPos, 0.25f);
        }
        
    }


}
