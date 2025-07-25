using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    [SerializeField]
    private Text _coinsText;
    [SerializeField]
    private UnityEvent _OnCoinsUpdated;
    public void UpdateCoins(int coinsNumber)
    {
        _coinsText.text = "x" + coinsNumber;
        _OnCoinsUpdated.Invoke();
    }
}
