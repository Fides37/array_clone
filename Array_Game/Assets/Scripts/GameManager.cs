using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector2 target;
    private float speed;

    public Vector3 enemyPos1;
    public Vector3 enemyPos2;
    public Vector3 enemyPos3;

    public Vector2 playerPos1;
    public Vector2 playerPos2;
    public Vector2 playerPos3;

    public bool dealEnemy;
    bool dealPlayer;
    private GameObject CardOne;
    private GameObject CardTwo;
    private GameObject CardThree;
    
    public Vector3 EnemyPos1;
    public Vector3 EnemyPos2;
    public Vector3 EnemyPos3;


    public GameObject [] deck = new GameObject [24];

    private enum TurnStates
    {
        Shuffle,
        MoveCards,
        RevealCards,
        Compare,
    }

    TurnStates turnStates;

    // Start is called before the first frame update
    void Start()
    {

        ShuffleDeck(deck);

        dealEnemy = true;

        speed = 5f;
   
    }

    // Update is called once per frame
    void Update()
    {
      
        
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            DealCards();
        }

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

    private void DealCards()
    {

        if (dealEnemy)
        {
            CardOne = deck[0];
            CardTwo = deck[1];
            CardThree = deck[2];

            if (CardOne.transform.position != EnemyPos1)
            {
                CardOne.GetComponent<CardMovement>().SetNewLerp(enemyPos1.x, enemyPos1.y);
            }
            else if (CardTwo.transform.position != EnemyPos2)
            {
                Debug.Log("whatt");
                CardTwo.GetComponent<CardMovement>().SetNewLerp(enemyPos2.x, enemyPos2.y);
            }
            else if (CardThree.transform.position != EnemyPos3)
            {
                CardThree.GetComponent<CardMovement>().SetNewLerp(enemyPos3.x, enemyPos3.y);
            }
        

        }

        //for (int x = 0; x <deck.Length; x++)
        //{
        //    if (x == 0)
        //    {
        //        deck[x].GetComponent<CardMovement>().SetNewLerp(enemyPos1.x, enemyPos1.y);
        //    }
        //    else if (x == 1)
        //    {
        //        deck[x].GetComponent<CardMovement>().SetNewLerp(enemyPos2.x, enemyPos2.y);
        //    }
        //    else if (x == 2)
        //    {
        //        deck[x].GetComponent<CardMovement>().SetNewLerp(enemyPos3.x, enemyPos3.y);
        //    }
        //}
    }


 

}
