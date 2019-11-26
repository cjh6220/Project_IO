using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase
{
    public int itemType;    //아이템 종류
    public int value;       //아이템이 보유한 값
    public Texture boxTexture;

    public ItemBase()
    {

    }

    public void MoveItem()
    {

    }

    public virtual void ApplyValue() { }    //값을 플레이어에게 적용할 수 있는 함수
}
