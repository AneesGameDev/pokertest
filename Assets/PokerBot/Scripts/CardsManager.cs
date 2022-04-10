using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class CardsManager : MonoBehaviour
{

    public List<Scriptable> deck = new List<Scriptable>();

    public GameObject cardPrefab;
    public List<Scriptable> listofCards;

    public float offset_card =0.8f;
    public GameObject[] placeholderPlayerHands;

   
/*    public GameObject placeholderBoard;
    public GameObject placeholderHand;

    
    public GameObject[] compare_Buttons;
    #endregion

    public List<Card> board_cards;*/
[SerializeField]
    public List<Card>[] player_cards = new List<Card>[6];

    private GameObject cardTempObj;

    private int num_hand = 1;
    private int num_cards_board = 0;




    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < player_cards.Length; i++)
        {
            player_cards[i] = new List<Card>();
        }

        for(int i=0; i<listofCards.Count; i++)
		{
            deck.Add(listofCards[i]);
		}
        //deck = ShuffleDeck(deck);

        //deck = listofCards;
        Debug.Log("Deck Count is" + deck.Count);
        Draw6PlayerHands();
        
    }
    public void Draw6PlayerHands()
    {

        if (player_cards[0].Count == 0)
        {
            
           //deck.Shuffle();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   // int rand = UnityEngine.Random.Range(0, deck.Count);
                    var cardObj = InstantiateCard(deck[j], placeholderPlayerHands[i].transform.position, placeholderPlayerHands[i].transform, j);




                    player_cards[i].Add(cardObj.GetComponent<Card>());
                    deck.Remove(deck[j]);
                }
               // compare_Buttons[i].SetActive(true);
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject InstantiateCard(Scriptable scriptable, Vector3 pos, Transform parent, float num_card)
    {


        cardTempObj = Instantiate(cardPrefab, new Vector3(pos.x + (offset_card*num_card)/2 , pos.y /*- (2 * offset_card)*/, 0), Quaternion.identity, parent);



        cardTempObj.GetComponent<Card>().cardValue = scriptable.cardValue;
        cardTempObj.GetComponent<Card>().cardColor = scriptable.cardColor;
       // cardTempObj.name = scriptable.cardSprite.name.ToString(); //scriptable.cardValue.ToString() + scriptable.cardColor.ToString();

        cardTempObj.transform.GetChild(1).GetComponent<Image>().sprite = scriptable.cardSprite;

        //cardTempObj.transform.GetChild(1).GetComponent<Image>().sprite = scriptable.cardSprite;
       // cardTempObj.transform.GetChild(2).GetComponent<Image>().sprite = scriptable.cardSprite;


        return cardTempObj;

    }

/*    public List<Scriptable> ShuffleDeck(List<Scriptable> deck)
	{
        List<Scriptable> shuffleDeck = new List<Scriptable>();

		//List<Card> shuffleDeck = new List<Card>();
		System.Random r = new System.Random();
        int p = 0;
        while (deck.Count > 0)
        {
            p = r.Next(0, deck.Count);
            shuffleDeck.Add(deck[p]);
            deck.Remove(deck[p]);
        }
        return shuffleDeck;
    }*/


}
