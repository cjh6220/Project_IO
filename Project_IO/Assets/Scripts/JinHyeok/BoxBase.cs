using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoxType
{
    Type_Tree = 0,
    Type_Sliver = 1,
    Type_Gold = 2,
}

public class BoxBase
{
    public BoxType boxType;
    public int maxHit;
    public int presentHit;
    private List<ItemBase> itemList;

    public BoxBase()
    {
        CreateItems();
    }

    private void CreateItems()
    {
        int totalCount = 0;
        switch(boxType)
        {
            case BoxType.Type_Tree: totalCount = 1; break;
            case BoxType.Type_Sliver: totalCount = 2; break;
            case BoxType.Type_Gold: totalCount = 3; break;
            default: Debug.LogError("Can't Create Item : This box doesn't have box type info"); return;
        }
        int presentCount = Random.Range(totalCount, totalCount + 2);

        for (int i = 0; i < presentCount; i++)
        {
            ItemBase nItem = new ItemBase();
            itemList.Add(nItem);
        }
    }

    public void DropItems()
    {

    }
}
