                                                                                                               using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum CharacterStack

{
    Int,Hp,Str
}
[Serializable]
public class ItemAbility 
{
    public CharacterStack characterStack;

    // 캐릭터 능력치 값
    public int valStack;

    [SerializeField]
    int min;
    int max;

    public int Min => min;
    public int Max => max;
    public ItemAbility(int min,int max)
    {
        this.min = min;
        this.max = max;

        GetstackValue();
    }

    private void GetstackValue()
    {
        valStack = UnityEngine.Random.Range(min, max);
    }

    public void AddStackVal(ref int v)
    {
        v += valStack;
    }
}
