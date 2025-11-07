using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Vector2 PlayerHover1;
    public Vector2 PlayerHover2;
    public Vector2 PlayerHover3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter2D(Collider2D other)
    {
        gameObject.transform.DOMove(PlayerHover1, 0.5f);
    }


}
