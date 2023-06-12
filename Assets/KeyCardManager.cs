using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardManager : MonoBehaviour
{
    public static KeyCardManager KCM;
    public List<KeyCard> _Keycards;

    public List<int> _PickedUpKeyCards = new List<int>();

    private void Randomize()

    {
        for (int i = 0; i < _Keycards.Count; i++)
        {
            _Keycards[i].SetCode(Random.Range(1000, 9999));
        }
    }

    public void AddKeyindex(int index)
    {
        _PickedUpKeyCards.Add(index);
    }

    private void Awake()
    {
        KCM = this;
        Randomize();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}