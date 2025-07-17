using UnityEngine;
using UnityEngine.Events;
public class UiCoinsNumber : MonoBehaviour
{
    [SerializeField]
    private int _coins = 0;
    [SerializeField]
    private UnityEvent<int> _onCoinsUpdated;
    public void addCoins(int amount)
    {
        _coins += amount;
        _onCoinsUpdated?.Invoke(_coins);
    }
    public void SetCoins(int amount)
    {
        _coins = amount;
        _onCoinsUpdated?.Invoke(_coins);
    }
    public void Subtractoins(int amount)
    {
        _coins -= amount;
        _onCoinsUpdated?.Invoke(_coins);
    }
}
