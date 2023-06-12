using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class KeyCard
{
    [SerializeField]
    private int _Code;

    public int GetCode()
    {
        return _Code;
    }

    public void SetCode(int code)
    {
        _Code = code;
    }
}