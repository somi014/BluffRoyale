using UnityEngine;

[CreateAssetMenu(fileName = "CardInfo", menuName = "Scriptable Objects/CardInfo")]
public class CardScriptableObject : ScriptableObject
{
    [SerializeField] private Sprite cardImage;
    [SerializeField] private CardType cardType;
    
    [SerializeField] private bool isSelected;
    [SerializeField] private bool isOnHand;  
}
