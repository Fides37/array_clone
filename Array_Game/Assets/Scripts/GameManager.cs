using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject RockCard;
    public GameObject PaperCard;
    public GameObject ScissorCard;

    public GameObject [] deck = new GameObject [10];

    


    // Start is called before the first frame update
    void Start()
    {
        ShuffleDeck(deck);
   
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }


    private void ShuffleDeck(GameObject[] deck)
    {
        for (int cardIndex = 0; cardIndex < deck.Length; cardIndex++)
        {
            Debug.Log(deck[cardIndex].name);

            GameObject tempCard = deck[cardIndex];
            int newIndex = Random.Range(cardIndex, deck.Length);
            deck[cardIndex] = deck[newIndex];
            deck[newIndex] = tempCard;


        }


    }


    private void MoveCards()
    {
        
    }

}
