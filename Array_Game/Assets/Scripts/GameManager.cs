using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

public class GameManager : MonoBehaviour
{

    public Vector3 PlayerPos1;
    public Vector3 PlayerPos2;
    public Vector3 PlayerPos3;

    public bool dealEnemy;
    bool dealPlayer;

    private GameObject CardOne;
    private GameObject CardTwo;
    private GameObject CardThree;
    
    public Vector3 EnemyPos1;
    public Vector3 EnemyPos2;
    public Vector3 EnemyPos3;

    private int round;




    public GameObject [] deck = new GameObject [24];

    private enum TurnStates
    {
        Shuffle,
        DealCards,
        RevealCards,
        Compare,
        Discard
    }

    TurnStates turnStates;

    // Start is called before the first frame update
    void Start()
    {
        turnStates = TurnStates.Shuffle;

   
    }

    // Update is called once per frame
    void Update()
    {

        switch (turnStates)
        {
            case (TurnStates.Shuffle):
                ShuffleDeck(deck);
                break;
            case (TurnStates.DealCards):

                if (round == 0)
                {
                    DealCardsRoundOne();
                }
                else if (round == 1)
                {
                    DealCardsRoundTwo();
                }
                else if (round == 2)
                {
                    DealCardsRoundThree();
                }
                else if (round == 3)
                {
                    DealCardsRoundThree();
                }

                break;

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

    private void DealCardsRoundOne()
    {

    
        for (int x = 0; x < deck.Length; x++)
        {
            // first round enemy deal
            if (x == 0)
            {
                deck[x].transform.DOMove(EnemyPos1, 1f).SetDelay(0f).SetEase(Ease.OutExpo);
            }
            else if (x == 1)
            {
                deck[x].transform.DOMove(EnemyPos2, 1f).SetDelay(0.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 2)
            {
                deck[x].transform.DOMove(EnemyPos3, 1f).SetDelay(1f).SetEase(Ease.OutExpo);
            }

            // first round player deal 
            if (x == 3)
            {
                
                deck[x].transform.DOMove(PlayerPos1, 1f).SetDelay(2f).SetEase(Ease.OutExpo);
            }
            else if (x == 4)
            {
                deck[x] = CardTwo;
                deck[x].transform.DOMove(PlayerPos2, 1f).SetDelay(2.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 5)
            {
                deck[x] = CardThree;
                deck[x].transform.DOMove(PlayerPos3, 1f).SetDelay(3f).SetEase(Ease.OutExpo);
            }

        }

        if (CardThree.transform.position == PlayerPos3)
        {
            
        }

        round += 1;
    }


    private void DealCardsRoundTwo()
    {
        for (int x = 0; x < deck.Length; x++)
        {
            if (x == 6)
            {
                deck[x].transform.DOMove(EnemyPos1, 1f).SetDelay(0f).SetEase(Ease.OutExpo);
            }
            else if (x == 7)
            {
                deck[x].transform.DOMove(EnemyPos2, 1f).SetDelay(0.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 8)
            {
                deck[x].transform.DOMove(EnemyPos3, 1f).SetDelay(1f).SetEase(Ease.OutExpo);
            }

            // second round player deal
            if (x == 9)
            {
                deck[x].transform.DOMove(PlayerPos1, 1f).SetDelay(2f).SetEase(Ease.OutExpo);
            }
            else if (x == 10)
            {
                deck[x].transform.DOMove(PlayerPos2, 1f).SetDelay(2.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 11)
            {
                deck[x].transform.DOMove(PlayerPos3, 1f).SetDelay(3f).SetEase(Ease.OutExpo);
            }
        }

        round += 1;
    }

    private void DealCardsRoundThree()
    {
        for (int x = 0; x < deck.Length; x++)
        {
            if (x == 12)
            {
                deck[x].transform.DOMove(EnemyPos1, 1f).SetDelay(0f).SetEase(Ease.OutExpo);
            }
            else if (x == 13)
            {
                deck[x].transform.DOMove(EnemyPos2, 1f).SetDelay(0.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 14)
            {
                deck[x].transform.DOMove(EnemyPos3, 1f).SetDelay(1f).SetEase(Ease.OutExpo);
            }

            // third round player deal

            if (x == 15)
            {
                deck[x].transform.DOMove(PlayerPos1, 1f).SetDelay(2f).SetEase(Ease.OutExpo);
            }
            else if (x == 16)
            {
                deck[x].transform.DOMove(PlayerPos2, 1f).SetDelay(2.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 17)
            {
                deck[x].transform.DOMove(PlayerPos3, 1f).SetDelay(3f).SetEase(Ease.OutExpo);
            }
        }

        round += 1;

    }

    private void DealCardsRoundFour()
    {
        for (int x = 0; x < deck.Length; x++)
        {
            // fourth round enemy deal
            if (x == 18)
            {
                deck[x].transform.DOMove(EnemyPos1, 1f).SetDelay(0f).SetEase(Ease.OutExpo);
            }
            else if (x == 19)
            {
                deck[x].transform.DOMove(EnemyPos2, 1f).SetDelay(0.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 20)
            {
                deck[x].transform.DOMove(EnemyPos3, 1f).SetDelay(1f).SetEase(Ease.OutExpo);
            }

            //fourth round player deal

            if (x == 21)
            {
                deck[x].transform.DOMove(PlayerPos1, 1f).SetDelay(2f).SetEase(Ease.OutExpo);
            }
            else if (x == 22)
            {
                deck[x].transform.DOMove(PlayerPos2, 1f).SetDelay(2.5f).SetEase(Ease.OutExpo);
            }
            else if (x == 23)
            {
                deck[x].transform.DOMove(PlayerPos3, 1f).SetDelay(3f).SetEase(Ease.OutExpo);
            }
        }

        round += 1;

    }
 

}
