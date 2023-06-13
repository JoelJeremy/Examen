using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardManager : MonoBehaviour
{
    public static KeyCardManager KCM;
    public List<KeyCard> _Keycards;

    //this list holds all the keycard codes that are generated. in this case the will only be 1 code generated meaning that
    //It will be holding 1 keycode.
    public List<int> _PickedUpKeyCards = new List<int>();

    private void Randomize()

    {
        //This randomizes the generated keycard code.
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
        //Before the game starts the system already calls the randomize function in this script.
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