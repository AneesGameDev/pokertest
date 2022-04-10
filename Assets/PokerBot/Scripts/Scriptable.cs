using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardValue { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace };
public enum CardColor { hearts, diamonds, spades, clubs }

[CreateAssetMenu(fileName = "Cards", menuName = "ScriptableObjects", order = 1)]


public class Scriptable : ScriptableObject
{
  
    public Sprite cardSprite;
    public CardValue cardValue;
    public CardColor cardColor;


}
